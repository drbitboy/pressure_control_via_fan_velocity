# Simple dSpeed/dt control of pressure in a controller

![](https://github.com/drbitboy/pressure_control_via_fan_velocity/raw/master/src/dsdt_pressure_control/doc/img/dsdt_pressure_control.png)

    t = time, s
    delt = 1s; time step and PID loop update; 1s for simplicity
    S = fan speed
    P or P(t) = pressure at time t
    Pss = steady state pressure at constant fan speed
    Ffan = Fan flow
    Pfan(S,Ffan) = Fan pressure as a function of fan speed and flow
    Pmax = Max Pfan, i.e. at zero Ffan
    Fmax = Max Ffan, i.e. at zero Pfan
    Fleac = leakage flow
    Tc = decay time constance, from P(t) to P(t+delt), toward Pss
    Kt = e**(-delt/Tc); fractional decay, from P(t -> t+delt), toward Pss
    Kc = Proportional gain for PID with PV=P and CV=deltaS/delt

    K1, K2, etc. = misc. constants that disappear in the final formulations

    Models
    ======

      Fan:  Pressure as a function of fan speed (S) and flow

        Pfan = Pmax(S) - K2 fanFlow**2

        Pmax(s) = K1 S

      Leakage:  Pressure as a function of leavage flow

        Pleak = K3 Fleak**2

      Steady-state pressure

        Pss = Kss S

        Derived from Fan and Leakage models, above:
        1) Ffan = Fleak
        2) Pfan = Pleak
        3) => Kss = K1 K2 / (K1 + K3)

      Pressure dynamics (approximated as an exponential decay):

        dP/dt = (Pss - P) / Tc

        => 

        P(t+delt) = Pss (1-Kt) + Kt P(t)

        N.B. Assumes Pss constant over [t:t+delt];
             assumes instantaneous responses of fan speed and flow

      Fan speed control

        dS/dt ~ (S(t) - S(t-delt)) / delT = Kc (SP - P)

        =>

        S(t) = S(t-delt) + Kc (SP - P)

        N.B. Reverse-(re-)acting PID with 0 = Ti = Td, and CV ~ dS/dt

