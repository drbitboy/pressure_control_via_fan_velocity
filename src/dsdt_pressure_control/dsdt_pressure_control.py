"""
t = time, s
delt = 1s; time step and PID loop update; 1s for simplicity
S = fan speed
P or P(t) = pressure at time t
Pss = steady state pressure at constant fan speed
Tc = decay time constance, from P(t) to P(t+delt), toward Pss
Kt = e**(-delt/Tc); fractional decay, from P(t -> t+delt), toward Pss
Kc = Proportional gain for PID with PV=P and CV=deltaS/delt

Models
======

  Steady-state pressure

    Pss = Kss S

  Pressure dynamics

    dP/dt = (Pss - P) / Tc

    => 

    P(t+delt) = Pss (1-Kt) + Kt P(t)

    N.B. Assumes Pss constant over [t:t+delt];
         assumes instantaneous responses of fan speed and flow

  Fan speed

    S(t) = S(t-delt) + Kc (SP - P)

    N.B. Reverse-(re-)acting PID with 0 = Ti = Td

"""
import os
import sys
import matplotlib.pyplot as plt

if "__main__" == __name__:

  Kss = 0.01               ### 100% fan speed yields Pss = 1PSIG
  Tc = 10.0                ### Tc = 10s
  Kt = 2.71828**(-1.0/Tc)  ### ~ e**(-Tc 1s)
  oneminus_Kt = 1.0 - Kt   ### 1 - Kt

  S0 = 5.0                                  ### S(t=0)
  P0 = S0 * Kss                             ### P(t=0)
  SP = (S0 + 10.0) * Kss                    ### Setpoint

  for logKc2 in range(9):                   ### 0 to 8

    Kc = (10**((1.0-logKc2)/2.0)) / Kss     ### 3.16/Kss to 3.16E-4/Kss

    S,P = S0,P0                             ### Initial conditions

    ### Model Pressure over 10k steps of 1s
    ### N.B. assumes instantaneous fan and flow rate response

    lt = list()
    for i in range(10000):
      S += (SP - P) * Kc                        ### Controller re-action
      Pss = S * Kss                             ### Steady state
      P = (oneminus_Kt * Pss) + (Kt * P)        ### Decay toward Pss
      lt.append(P)                              ### Append datum to list

    if not logKc2: plt.axhline(SP,linestyle='dotted')
    plt.plot(lt,label='Kc={0:.2f}'.format(Kc))  ### Plot data

  ### Annotate and .show plot
  plt.title('Kss={0:.2f}; Tc={1}; S(t=0)={2}; Pss(t=0)={3}; SP={4}'
            .format(Kss,Tc,S0,P0,SP)
           )
  plt.xlabel('Time, s')
  plt.ylabel('Pressure, PSIG')
  plt.legend(loc='upper right')
  plt.show()
