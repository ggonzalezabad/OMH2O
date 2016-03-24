#!/bin/csh
# This script is intended to launch a series of jobs to perform  the
# HCHO retrieval for different orbits.
# The list of orbits is to be found in Orbit.list with three columns
# Orbit   Radiance_reference  and Irradiance
# ./src folder of the pge to be analized. It is assumed that the pge
# is updated and compiled before the jobs are launched.
date
set FOLDER=`pwd`
set PGE=OMH2O

# Find number of available cpus
set ncpu=`grep -i "model name" /proc/cpuinfo | wc -l`
echo $ncpu
# A different folder is created for each calculation, later on they
# are deleted but all these actions are done in Job.Windowing

@ i=1
foreach line ("`cat Orbits.list4`")

	# Creating the control file for each run (nothing to be done here)
        set orbit=`echo ${line} | awk '{print $1}'`
	set irrad=`echo ${line} | awk '{print $3}'`
	set Or=`ls ../out/OMI-Aura_L1-OML1BRVG_2006m07*-o${orbit}*`
	set Ir=`ls ../out/OMI-Aura_L1-OML1BIRR_2006m07*-o${irrad}*`
	set Cd=`ls ../out/OMI-Aura_L2-OMCLDO2_2006m07*-o${orbit}*`
	set Ou=OMH2O-o${orbit}_I0.he5
      
    # Creating a pcf file for each window
	set pcf=./${PGE}.pcf_${orbit}
	sed -e "s=+Or+=${Or}=g"  \
	    -e "s=+Cd+=${Cd}=g"  \
	    -e "s=+Ir+=${Ir}=g"  \
	    -e "s=+Ou+=${Ou}=g"  ./${PGE}_template.pcf > ${pcf}

    # Running the job
    if ($i < ${ncpu})  then
         ../../nonTLCF_Make/runapp ${pcf} &
         sleep 10
	 rm -f ${pcf}
    endif
    if ($i == ${ncpu}) then
        ../../nonTLCF_Make/runapp ${pcf}
        @ i=0
	rm -f ${pcf}
    endif
    @ i++
end
date

#EOF
