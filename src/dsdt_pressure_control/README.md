# Simple dSpeed/dt control of pressure in a controller

![](https://github.com/drbitboy/pressure_control_via_fan_velocity/raw/master/src/dsdt_pressure_control/doc/img/dsdt_pressure_control.png)

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

