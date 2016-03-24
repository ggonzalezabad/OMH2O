---
MShortname:   OMH2O
Longname:     OMI/Aura water vapor (H2O) Total Column 1-Orbit L2 Swath 13x24km
PFS Version:  1.0.0
Date:         26 August 2013
Author(s):    Gonzalo Gonzalez Abad (SAO)
              Helen Wang (SAO)
              Thomas P. Kurosu

PGE Version:  	           1.0.0
Lead Algorithm Scientist:  Kelly Chance (SAO)
Lead Algorithm Developer:  Kelly Chance (SAO)
Lead PGE Developer:        Thomas P. Kurosu (SAO)
PGE Developer(s):          Gonzalo Gonzalez Abad (SAO)
                           Helen Wang (SAO)
                           Thomas P. Kurosu

Description:  >  
 
 This document specifies the product format for the Version 1.0.0 delivery
 of the OMH2O L2 PGE, which uses a Basic Optical Absorption Spectroscopy
 (BOAS) type algorithm based on non-linear least squares fitting to estimate
 total column H2O from OMI VIS measurements.  The product is stored as one
 HDF-EOS 5 swath file for each granule (i.e., one orbit) of OMI L1B data,
 and has a size range of 20 to 45 Mb.  The reference for the product is
 ATBD-OMI-04 entitled "OMI Trace Gas Algorithms".


Global Metadata:

 - Metadata Name:     AuthorAffiliation
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       PCF
   Description:       Actual is "Smithsonian Astrophysical Observatory".

 - Metadata Name:     AuthorName
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       PCF
   Description:       Actual is "Thomas P. Kurosu / Gonzalo Gonzalez Abad / Helen Wang".

 - Metadata Name:     GranuleDay
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     1
   Maximum Value:     31
   Data Source:       PGE
   Description:       The day of the month at the start of the granule.

 - Metadata Name:     GranuleMonth
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     1
   Maximum Value:     12
   Data Source:       PGE
   Description:       The month at the start of the granule.

 - Metadata Name:     GranuleYear
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     2003
   Maximum Value:     2099
   Data Source:       PGE
   Description:       The (four-digit) year at the start of the granule.

 - Metadata Name:     HDFEOSVersion
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Automatically set by HDF-EOS.
   Data Source:       HE
   Description:       Example is "HDFEOS_5.1.8".

 - Metadata Name:     InputVersions
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       PGE
   Description: >
    A list of every ESDT (including version) whose product was used as
    input for the processing.

 - Metadata Name:     InstrumentName
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            HIRDLS,MLS,OMI,TES
   Data Source:       PCF
   Description:       Actual is "OMI" (see Section 6.1 of Reference 2).

 - Metadata Name:     NumberOfBadOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which retrieval
    was performed and quality status is 'bad'.

 - Metadata Name:     FittingWindowLimits
   Mandatory:         T
   Data Type:         HE5T_NATIVE_FLOAT
   Number of Values:  6
   Minimum Value:     0
   Maximum Value:     500.0
   Data Source:       PGE
   Description:       >
    1: First wavelength of total wavelength interval
    2: First wavelength of fitting window considered in fit
    3: Last  wavelength of fitting window considered in fit
    4: Last  wavelength of total wavelength interval
    5: First wavelength of any interval excluded from fit
    6: Last  wavelength of any interval excluded from fit
    Numbers 2 and 3 define the actual fitting window, bracketed
    by numbers 1 and 4 (usually +/-2nm on each end). Numbers 5
    and 6 are ignored if there is no overlap with the fitting
    window.

 - Metadata Name:     NumberOfConvergedSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which the non-linear
    least squares fit converged.

 - Metadata Name:     NumberOfCrossTrackPixels
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of across-track pixels for each scan line. Typical value is 60.

 - Metadata Name:     NumberOfExceededIterationsSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which the non-linear
    least squares fit failed to converge because the maximum number
    of allowed iterations was exceeded.

 - Metadata Name:     NumberOfFailedConvergenceSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which the non-linear
    least squares fit failed to converge.

 - Metadata Name:     NumberOfGoodInputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule on which retrieval
    is performed.

 - Metadata Name:     NumberOfGoodOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which retrieval
    was successful.

 - Metadata Name:     NumberOfInputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule on which retrieval
    is performed.

 - Metadata Name:     NumberOfOutOfBoundsSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which the retrieved
    columns are "out of bounds", i.e., negative within twice the
    retrieval uncertainties.

 - Metadata Name:     NumberOfScanLines
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       Number of scan lines in radiance granule

 - Metadata Name:     NumberOfSuspectOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_INT
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     2147483647
   Data Source:       PGE
   Description:       >
    Number of measurement pixels in granule for which retrieval
    was performed and quality status is 'suspect'.

 - Metadata Name:     OrbitData
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            DEFINITIVE,PREDICTED
   Data Source:       L1B
   Description: >
    Indicates whether orbit data used by the L1B processor is definitive
    or predicted.
 
 - Metadata Name:     PercentBadOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_FLOAT
   Number of Values:  1
   Minimum Value:     0.0
   Maximum Value:     100.0
   Data Source:       PGE
   Description:       >
    Percentage of performed retrievals with quality status 'bad'.

 - Metadata Name:     PercentGoodOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_FLOAT
   Number of Values:  1
   Minimum Value:     0.0
   Maximum Value:     100.0
   Data Source:       PGE
   Description:       >
    Percentage of performed retrievals with quality status 'good'.

 - Metadata Name:     PercentSuspectOutputSamples
   Mandatory:         T
   Data Type:         HE5T_NATIVE_FLOAT
   Number of Values:  1
   Minimum Value:     0.0
   Maximum Value:     100.0
   Data Source:       PGE
   Description:       >
    Percentage of performed retrievals with quality status 'suspect'.

 - Metadata Name:     PGEVERSION
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Minimum Value:     0.0.
   Maximum Value:     9.9.99
   Data Source:       PCF
   Description:       Actual is "1.0.0".

 - Metadata Name:     ProcessingCenter
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       PCF
   Description:       Example is "OMIDAPS".

 - Metadata Name:     ProcessingHost
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       PCF
   Description:       >
    The output from executing the Unix "uname -a" command on the
    processing machine.

 - Metadata Name:     ProcessLevel
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            1b,2,3
   Data Source:       PCF
   Description:       Actual is "2".

 - Metadata Name:     SpaceCraftMaxAltitude
   Mandatory:         T
   Data Type:         HE5T_NATIVE_DOUBLE
   Number of Values:  1
   Minimum Value:     0.0e+00
   Maximum Value:     1.0e+30
   Data Source:       L1B
   Description:       >
    Maximum elevation of the Aura space craft (in m).

 - Metadata Name:     SpaceCraftMinAltitude
   Mandatory:         T
   Data Type:         HE5T_NATIVE_DOUBLE
   Number of Values:  1
   Minimum Value:     0.0e+00
   Maximum Value:     1.0e+30
   Data Source:       L1B
   Description:       >
    Minimum elevation of the Aura space craft (in m).

 - Metadata Name:     TAI93At0zOfGranule
   Mandatory:         T
   Data Type:         HE5T_NATIVE_DOUBLE
   Number of Values:  1
   Minimum Value:     0.0e+00
   Maximum Value:     1.0e+30
   Data Source:       PGE
   Description:       >
    The TAI93 time at 0z of the granule (see Section 6.1 of Reference 2).


Swath Metadata:

 - Metadata Name:     EarthSunDistance
   Mandatory:         T
   Data Type:         HE5T_NATIVE_FLOAT
   Number of Values:  1
   Minimum Value:     1.47e+11
   Maximum Value:     1.53e+11
   Data Source:       L1B
   Description: >
    The Earth-sun distance (in m) at the time of the irradiance
    measurement.
 
 - Metadata Name:     SwathName
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            OMI Total Column Amount H2O
   Data Source:       PGE
   Description:       Actual is "OMI Total Column Amount H2O".

 - Metadata Name:     VerticalCoordinate
   Mandatory:         T
   Data Type:         HE5T_NATIVE_CHAR
   Number of Values:  1
   Valids:            Pressure,Altitude,Potential Temperature,Slant Column,Total Column
   Data Source:       PGE
   Description: >
    Actual is "Total Column" (see Section 6.2 of Reference 2).


Swath Dimensions:

 - Dimension Name:    nTimes
   Data Type:         HE5T_NATIVE_INT
   Dimension Type:    FIXED
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       The number of "scan" lines in the swath.

 - Dimension Name:    nUTCdim
   Data Type:         HE5T_NATIVE_INT
   Dimension Type:    FIXED
   Number of Values:  1
   Minimum Value:     6
   Maximum Value:     6
   Data Source:       PGE
   Description:       The number of elements in the TimeUTC geolocation field.

 - Dimension Name:    nXtrack
   Data Type:         HE5T_NATIVE_INT
   Dimension Type:    FIXED
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     60
   Data Source:       L1B
   Description:       The number of ground pixels per "scan" line.

Geolocation Fields:

 - Field Name:               Latitude
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -90.0
   Maximum Value:            90.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Geodetic Latitude"
   Unique Field Definition:  Aura-Shared
   Description:              >
    The geodetic latitude (in deg) at the center of the ground pixel.

 - Field Name:               Longitude
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -180.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Geodetic Longitude"
   Unique Field Definition:  Aura-Shared
   Description:              >
    The geodetic longitude (in deg) at the center of the ground pixel.

 - Field Name:               SolarAzimuthAngle
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -180.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Solar Azimuth Angle"
   Unique Field Definition:  Aura-shared
   Description:              >
    The solar azimuth angle (in deg) at the center of the ground pixel.

 - Field Name:               SolarZenithAngle
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Solar Zenith Angle"
   Unique Field Definition:  Aura-shared
   Description:              >
    The solar zenith angle (in deg) at the center of the ground pixel.

 - Field Name:               SpacecraftAltitude
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    m
   Data Source:              L1B
   Title:                    "Altitude of the Aura Spacecraft"
   Unique Field Definition:  Aura-Shared
   Description:              >
    The altitude (in m) of the EOS-Aura satellite above WGS84
    ellipsoid.

 - Field Name:               TerrainHeight
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1000
   Maximum Value:            10000
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    m
   Data Source:              L1B
   Title:                    "Terrain Height"
   Unique Field Definition:  Aura-Shared
   Description:              >
    The terrain height (in m) at the center of the ground pixel.

 - Field Name:               Time
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+10
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    s
   Data Source:              L1B
   Title:                    "Time in TAI units"
   Unique Field Definition:  Aura-Shared
   Description:              >
    The TAI93 time (in s) at the start of the "scan".

 - Field Name:               TimeUTC
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nUTCdim,nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            9999e+00
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Coordianted Universal Time"
   Unique Field Definition:  OMI-Specific
   Description:              >
    UTC value of the TAI93 time at the start of the "scan". UTC time of 
    format of the UTC string, YYYY-MM-DDThh:mm:ss.ddddddZ, is broken up
    into 6 integer fields containing
    YYYY = year             (position 1)
    MM   = month            (position 2)
    DD   = day              (position 3)
    hh   = hour             (position 4)
    mm   = minutes          (position 5)
    ss   = seconds          (position 6)

 - Field Name:               ViewingAzimuthAngle
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -180.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Viewing Azimuth Angle"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The viewing azimuth angle (in deg) at the center of the ground pixel.

 - Field Name:               ViewingZenithAngle
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              L1B
   Title:                    "Viewing Zenith Angle"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The viewing zenith angle (in deg) at the center of the ground pixel.

 - Field Name:               XTrackQualityFlags
   Data Type:                HE5T_NATIVE_INT8
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0
   Maximum Value:            127
   Missing Value:            -127
   Offset:                   0
   Scale Factor:             1
   Units:                    NoUnits
   Data Source:              L1B
   Title:                    "Cross-Track Quality Flags"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Cross-Track quality flags as set in the L1b to flag the row anomaly.

 - Field Name:               XTrackQualityFlagsExpanded
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0
   Maximum Value:            11147
   Missing Value:            -30000
   Offset:                   0
   Scale Factor:             1
   Units:                    NoUnits
   Data Source:              L1B
   Title:                    "Expanded Cross-Track Quality Flags"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Cross-Track quality flags as set in the L1b to flag the row anomaly.
    Expanded human-readable version of XtrackQualityFlags.

Data Fields:

 - Field Name:               AMFCloudFraction
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0
   Maximum Value:            1.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Adjusted Cloud Fraction for AMF Computation"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Cloud fraction from external cloud ESDT, adjusted such that it falls
    within the range of [0, 1].

 - Field Name:               AMFCloudPressure
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    hPa
   Data Source:              PGE
   Title:                    "Adjusted Cloud Pressure for AMF Computation"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Cloud pressure from external cloud ESDT.

 - Field Name:               AirMassFactor
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Molecule Specific Air Mass Factor (AMF)"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Molecule specific air mass factor for each ground pixel, including
    scattering weights,  clouds, and vertical distribution of H2O.

 - Field Name:               AirMassFactorDiagnosticFlag
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -2
   Maximum Value:            13127
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Diagnostic Flag for Molecule Specific AMF"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Diagnostic flag for molecule specific air mass factor for each 
    ground pixel. The flag indicates surface conditions and out of
    bound viewing geometry. Except for geometry and surface type,
    flag is computed additively, i.e., it is the sum of all the 
    conditions that apply to a ground pixel.

    Non-additive values
     =    -2  Out of bounds viewing geometry, no AMF computation possible
     =    -1  No table lookup possible; geometric AMF used instead
     = 0-100  NISE snow cover fraction
     =   101  NISE permanent ice
     =   103  NISE dry snow
     =   104  NISE ocean
     =   125  NISE suspect (no snow cover assumed)
     =   127  NISE error   (no snow cover assumed)

    Additive values
     +10000  Sun glint possibility; assume albedo for ice

 - Field Name:               AirMassFactorGeometric
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Geometric Air Mass Factor (AMF)"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Geometric air mass factor for the viewing geometry of each
    ground pixel.

 - Field Name:               Albedo
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Albedo"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Ground pixel albedo from the OMLER albedos database for the central
    wavelength of the fitting window.

 - Field Name:               AverageColumnAmount
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               1
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Average Column Amount"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount (in molecules/cm2) averaged
    over the the whole granule.

 - Field Name:               AverageColumnUncertainty
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               1
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Average Column Uncertainty"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount uncertainty (in molecules/cm2)
    averaged over the the whole granule.

 - Field Name:               AverageFittingRMS
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               1
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Average Fitting RMS"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Fitting RMS averaged over the the whole granule.

 - Field Name:               ClimatologyLevels
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes,nLevels
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    hPa
   Data Source:              PGE
   Title:                    "Climatology Levels"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Pressure at grid center of the GEOS-Chem climatology used in the AMFs calculations.
    Obtained from GEOS-Chem, GEOS5 reduced grid.
    Scattering weights are interpolated to this grid.

 - Field Name:               ColumnAmount
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Column Amount"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount (in molecules/cm2) for
    each ground pixel.

 - Field Name:               ColumnAmountDestriped
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Column Amount with Destriping Correction"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount (in molecules/cm2) for each ground pixel after
    application of a post-fitting destriping correction and cross-track
    bias removal.

 - Field Name:               ColumnUncertainty
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Column Uncertainty"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount uncertainty (in molecules/cm2)
    for each ground pixel.

 - Field Name:               FitConvergenceFlag
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -12
   Maximum Value:            12344
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Fitting Convergence Flag"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The flag indicating the type of (non-) convergence of the non-linear least 
    squares fitting routine associated with the ground pixel.
 
    Exit integer scalar that indicates why the return is taken:
     =10000 convergence due to criterion no. 1 below
     = 2000 convergence due to criterion no. 2 below
     =  300 convergence due to criterion no. 3 below
     =   40 convergence due to criterion no. 4 below
     =    x where x equals 0,1,2,3 or 4
     <    0 indicates that no convergence criterion is fulfilled but some 
            abnormal termination criterion is satisfied
     =   -1 if m<n or n<=0 or m<=0 or mdc<m or mdw<n*n+5*n+3*m+6 or maxit<=0 or 
            epsrel<0 or epsabs<0 or epsx<0 or invalid starting point   on entry
     =   -2 termination due to criterion no. 5
     =   -3 termination due to criterion no. 6
     =   -4 termination due to criterion no. 7
     =   -5 termination due to criterion no. 8
     =   -6 termination due to criterion no. 9
     =   -7 there is only one feasible point, namely x(i)=bl(i)=bu(i) ; i=1,2,...,n
     =  -11 termination due to user stop indicator: fitting parameters out of bounds
     =  -12 termination due to user stop indicator: "infinite loop" termination
 
    The convergence criteria are:
     1) relative predicted reduction in the objective function is less than epsrel**2
     2) the sum of squares is less than epsabs**2
     3) the relative change in x is less than epsx
     4) we are computing at noise level the last digit in the convergence code (see 
        below) indicates how the last steps were computed
        = 0 no trouble (gauss-newton the last 3 steps)
        = 1 prank<n at the termination point
        = 2 the method of newton was used (at least) in the last step
        = 3 the 2nd but last step was subspace minimization but the last two were gauss-newton steps
        = 4 the steplength was not unit in both the last two steps
 
    The abnormal termination criteria are:
     5) no. of iterations has exceeded maximum allowed iterations
     6) the hessian emanating from 2nd order method is not pos def
     7) the algorithm would like to use 2nd derivatives but is not allowed to do that
     8) an undamped step with newtons method is a failure
     9) the latest search direction computed using subspace minimization was not a 
        descent direction (probably caused by wrongly computed jacobian)
 
    The convergence constants and dimension parameters are:
     maxit  maximum number of allowed iterations
     tol    pseudo rank tolerance constant
     epsrel relative convergence constant
     epsabs absolute convergence constant
     epsx   parameter convergence constant
     n      integer scalar containing the number of unknowns
     mdc    integer scalar (mdc must be >= m)
     m      integer scalar containing the number of data points

 - Field Name:               FittingRMS
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Fitting RMS"
   Unique Field Definition:  OMI-Specific
   Description:              Fitting RMS for each ground pixel.

 - Field Name:               GasProfile
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes,nLevels
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    ppb
   Data Source:              PGE
   Title:                    "Gas Profile"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Gas profiles used in the AMFs calculation. Calculated with GEOS-Chem.

 - Field Name:               MainDataQualityFlag
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1
   Maximum Value:            2
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Main Data Quality Flag"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Main flag to indicate data quality. Its main purpose is to give the user
    of the data an easy way to screen for suspect or bad pixels. The possible
    values are -1=Missing, 0=Good, 1=Suspect, 2=Bad. They are determined as 
    follows.

    =  0   Column values are present and pass all quality checks. Data may
           be used with confidence
    =  1   Suspect columns. Data should be used with caution because one or
           more of the following quality checks failed:
           (a) FitConvergenceFlag is < 300 (but >= 0)
           (b) Column value plus 2 sigma fitting uncertainty is  < 0.0, but
               Column value plus 3 sigma fitting uncertainty is >= 0.0
           (c) Absolute column value larger than MaximumColumAmount
    =  2   Bad columns. Data should not be used at all, or only with extreme
           caution, because one or more of the following quality checks failed:
           (a) FitConvergenceFlag is < 0 (abnormal termination of fitting)
           (b) Column value plus 3 sigma fitting uncertainty is < 0.0
    <  0   No column values have been computed; entries are missing.

 - Field Name:               MaximumColumnAmount
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               1
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Maximum Column Amount for QA Flag 'good'"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Maximum absolute column amount up to which fitted colums qualify
    as 'good'. Beyond this value they are considered 'suspect'.

 - Field Name:               PixelArea
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack
   Minimum Value:            0.0
   Maximum Value:            4.13294e+08
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    km^2
   Data Source:              PGE
   Title:                    "Pixel Area"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The area (in km^2) of tiled ground pixels. One representative
    value for each cross-track position is provided.

 - Field Name:               PixelCornerLatitudes
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack+1,nTimes+1
   Minimum Value:            -90.0
   Maximum Value:            90.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              PGE
   Title:                    "Pixel Corner Latitude Coordinates"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The geodetic latitudes (in deg) of the corner coordinates of the
    OMI ground pixels.

 - Field Name:               PixelCornerLongitudes
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               nXtrack+1,nTimes+1
   Minimum Value:            -180.0
   Maximum Value:            180.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    deg
   Data Source:              PGE
   Title:                    "Pixel Corner Longitude Coordinates"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The geodetic longitudes (in deg) of the corner coordinates of the
    OMI ground pixels.

 - Field Name:               RadianceReferenceColumnAmount
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Radiance Reference Column Amount"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount (in molecules/cm2) for
    each ground pixel in the reference swath line.

 - Field Name:               RadianceReferenceColumnUncertainty
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Radiance Reference Column Uncertainty"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount uncertainty (in molecules/cm2)
    for each ground pixel in the reference swath line.

 - Field Name:               RadianceReferenceColumnXTRFit
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Radiance Reference Fit Colunm XTR Fit"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Cross-track fit (in molecules/cm2) to RadianceReferenceColumnAmount
    that is removed from the radiance reference spectrum if the option
    to remove the target gas from the radiance reference has been selected.

 - Field Name:               RadianceReferenceConvergenceFlag
   Data Type:                HE5T_NATIVE_INT16
   Dimensions:               nXtrack
   Minimum Value:            -10
   Maximum Value:            12344
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Radiance Reference Fit Convergence Flag"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The flag indicating the type of (non-) convergence of the non-linear
    least squares fitting routine for the reference swath line.
    For a detailed description of the flag refer to FitConvergenceFlag.

 - Field Name:               RadianceReferenceFittingRMS
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack
   Minimum Value:            0.0e+00
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Radiance Reference Fitting RMS"
   Unique Field Definition:  OMI-Specific
   Description:              >
     Fitting RMS for each ground pixel in the radiance reference line.

 - Field Name:               RadianceReferenceLatitudeRange
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               2
   Minimum Value:            -90.0
   Maximum Value:            90.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Radiance Reference Fit LatitudeRange"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Lower and upper latitude values defining the range that went into the
    composition of the radiance reference spectrum. If equal, a single swath
    line was used with latitude value at nadir closest to the lower latitude
    entry.

 - Field Name:               RadianceWavCalConvergenceFlag
   Data Type:                HE5T_NATIVE_INT
   Dimensions:               nXtrack
   Minimum Value:            -10
   Maximum Value:            12344
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Radiance Wavelength Calibration Convergence Flag"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The flag indicating the type of (non-) convergence of the non-linear
    least squares fitting routine for the radiance wavelength calibration.
    For a detailed description of the flag refer to FitConvergenceFlag.

 - Field Name:               RadianceWavCalLatitudeRange
   Data Type:                HE5T_NATIVE_FLOAT
   Dimensions:               2
   Minimum Value:            -90.0
   Maximum Value:            90.0
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Radiance Wavelength Calibration Fit LatitudeRange"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Lower and upper latitude values defining the range that went into the
    composition of the radiance spectrum used for wavelength calibration.
    If equal, a single swath line was used with latitude value at nadir 
    closest to the lower latitude entry.

 - Field Name:               ReferenceSectorCorrectedVerticalColumn
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    molec/cm2
   Data Source:              PGE
   Title:                    "Reference Sector Corrected Vertical Column"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Total column amount (in molecules/cm2) for
    each ground pixel obtained after correcting retrieved VCD with the
    reference sector climatology

 - Field Name:               ScatteringWeights
   Data Type:                HE5T_NATIVE_DOUBLE
   Dimensions:               nXtrack,nTimes,nLevels
   Minimum Value:            -1.0e+30
   Maximum Value:            1.0e+30
   Missing Value:            -1.0e+30
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Scattering Weights"
   Unique Field Definition:  OMI-Specific
   Description:              >
    Scattering weights used in the AMFs calculation. Calculated with VLIDORT.

 - Field Name:               SolarWavCalConvergenceFlag
   Data Type:                HE5T_NATIVE_INT
   Dimensions:               nXtrack
   Minimum Value:            -10
   Maximum Value:            12344
   Missing Value:            -30000
   Offset:                   0.0e+00
   Scale Factor:             1.0e+00
   Units:                    NoUnits
   Data Source:              PGE
   Title:                    "Solar Wavelength Calibration Convergence Flag"
   Unique Field Definition:  OMI-Specific
   Description:              >
    The flag indicating the type of (non-) convergence of the non-linear
    least squares fitting routine for the solar wavelength calibration.
    For a detailed description of the flag refer to FitConvergenceFlag.


Core Metadata:

 - Metadata Name:     AssociatedInstrumentShortName
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            OMI
   Data Source:       MCF
   Description:       Actual is "OMI".

 - Metadata Name:     AssociatedPlatformShortName
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            Aura
   Data Source:       MCF
   Description:       Actual is "Aura".

 - Metadata Name:     AssociatedSensorShortName
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            CCD Ultra Violet,CCD Visible
   Data Source:       MCF
   Description:       Actual is "CCD Visible".

 - Metadata Name:     AutomaticQualityFlag
   Mandatory:         T
   Data Type:         VA64
   Number of Values:  1
   Valids:            Passed,Suspect,Failed
   Data Source:       PGE
   Description:       >
    A granule-level quality flag that applies generally to the granule
    and specifically to the parameters at the granule level.

 - Metadata Name:     AutomaticQualityFlagExplanation
   Mandatory:         T
   Data Type:         VA255
   Number of Values:  1
   Valids:            Passed,Suspect,Failed
   Data Source:       PGE
   Description:       >
    The AutomaticQualityFlag is set to
    (1) "Passed"  if NrofGoodOutputSamples >= 75% of NrofGoodInputSamples
    (2) "Suspect" if NrofGoodOutputSamples >= 50% but < 75% of NrofGoodInputSamples
    (3) "Failed"  if NrofGoodOutputSamples  < 50% of NrofGoodInputSamples.

 - Metadata Name:     DayNightFlag
   Mandatory:         T
   Data Type:         VA5
   Number of Values:  1
   Valids:            Day,Night,Both
   Data Source:       MCF
   Description:       Actual is "Day".

 - Metadata Name:     EquatorCrossingDate
   Mandatory:         T
   Data Type:         D
   Number of Values:  1
   Minimum Value:     1995-01-01
   Maximum Value:     2099-12-31
   Data Source:       L1B
   Description:       >
    The date of the ascending equator crossing in the granule.

 - Metadata Name:     EquatorCrossingLongitude
   Mandatory:         T
   Data Type:         LF
   Number of Values:  1
   Minimum Value:     -180.0
   Maximum Value:     180.0
   Data Source:       L1B
   Description:       >
    The terrestrial longitude of the ascending equator crossing in the
    granule.

 - Metadata Name:     EquatorCrossingTime
   Mandatory:         T
   Data Type:         T
   Number of Values:  1
   Minimum Value:     01:00:0.000000
   Maximum Value:     01:59:59.999999
   Data Source:       L1B
   Description:       >
    The time of the ascending equator crossing in the granule.

 - Metadata Name:     InputPointer
   Mandatory:         T
   Data Type:         VA255
   Number of Values:  0 to 10
   Valids:            Not applicable (free format).
   Data Source:       PGE
   Description:       >
    Valid file names, each in double quotes, separated by commas, all
    surrounded by curved brackets. Example is
    ("OMI-Aura_L1-OML1BRVG_2007m0413t1703-o14598_v003-2007m0605t113435.he4", 
     "OMI-Aura_L1-OML1BRVG_2007m0413t0034-o14588_v003-2007m0605t114320.he4")

 - Metadata Name:     LocalGranuleID
   Mandatory:         T
   Data Type:         VA80
   Number of Values:  1
   Minimum Value:     OMI-Aura_L2-OMH2O_1995m0101t0000-o00000_v001-1995m0101t000000.he5
   Maximum Value:     OMI-Aura_L2-OMH2O_2099m1231t2359-o99999_v999-2099m1231t235959.he5
   Data Source:       PGE
   Description:       >
    Example is
    "OMI-Aura_L2-OMH2O_2007m0413t1703-o14598_v003-2008m0209t171735.he5"
    (see Appendix E of Reference 3).

 - Metadata Name:     LOCALVERSIONID
   Mandatory:         T
   Data Type:         VA60
   Number of Values:  1
   Valids:            RFC1321 MD5 = not yet calculated,RFC1321 MD5 = [0-9,a-f]{32}
   Data Source:       PCF
   Description:       MD5 fingerprint of the HDF product file.

 - Metadata Name:     OperationalQualityFlag
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            Passed,Failed,Being Investigated,Not Investigated, Inferred Passed, Inferred Failed,Suspect
   Data Source:       L1B
   Description:       >
    A granule-level quality flag that applies generally to the granule and
    specifically to the parameters at the granule level.

 - Metadata Name:     OperationalQualityFlagExplanation
   Mandatory:         T
   Data Type:         VA255
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       L1B
   Description:       >
    The criteria for setting the OperationalQualityFlag should be stated
    here (this Metadata will not appear in the granule).

 - Metadata Name:     OPERATIONMODE
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            Calibration,Diagnostic,Initialization,Launch,Normal,Roll,Routine,Safe,Solar Calibration,Standby,Survival,Test
   Data Source:       PCF
   Description:       Actual is "Test".

 - Metadata Name:     OrbitNumber
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     1
   Maximum Value:     999999
   Data Source:       L1B
   Description:       The OMI orbit number.

 - Metadata Name:     ParameterName
   Mandatory:         T
   Data Type:         VA40
   Number of Values:  1
   Valids:            Total Column Water Vapor
   Data Source:       PGE
   Description: >
    The measured science parameter expressed in the granule.

 - Metadata Name:     PGEVERSION
   Mandatory:         T
   Data Type:         VA10
   Number of Values:  1
   Minimum Value:     0.0.0
   Maximum Value:     9.9.99
   Data Source:       PCF
   Description:       Actual is "1.0.0".

 - Metadata Name:     ProductionDateTime
   Mandatory:         T
   Data Type:         DT
   Number of Values:  1
   Minimum Value:     2003-01-01T00:00:00.000Z
   Maximum Value:     2099-12-31T24:59:59.999Z
   Data Source:       TK
   Description:       The date and time of the Level 2 processing.

 - Metadata Name:     QAPercentMissingData
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       PGE
   Description:       >
    The percent of the data in the granule that are missing.

 - Metadata Name:     QAPercentOutofBoundsData
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       PGE
   Description: >
     The percent of the retrieved column data in the granule that
     are out of bounds.

 - Metadata Name:     RangeBeginningDate
   Mandatory:         T
   Data Type:         D
   Number of Values:  1
   Minimum Value:     1995-01-01
   Maximum Value:     2099-12-31
   Data Source:       L1B
   Description:       The year, month and day when the granule began.

 - Metadata Name:     RangeBeginningTime
   Mandatory:         T
   Data Type:         T
   Number of Values:  1
   Minimum Value:     00:00:00.000000
   Maximum Value:     23:59:59.999999
   Data Source:       L1B
   Description:       >
    The hour, minute, second and fraction of a second when the granule
    began.

 - Metadata Name:     RangeEndingDate
   Mandatory:         T
   Data Type:         D
   Number of Values:  1
   Minimum Value:     1995-01-01
   Maximum Value:     2099-12-31
   Data Source:       L1B
   Description:       The year, month and day when the granule ended.

 - Metadata Name:     RangeEndingTime
   Mandatory:         T
   Data Type:         T
   Number of Values:  1
   Minimum Value:     00:00:00.000000
   Maximum Value:     23:59:59.999999
   Data Source:       L1B
   Description:       >
    The hour, minute, second and fraction of a second when the granule
    ended.

 - Metadata Name:     REPROCESSINGACTUAL
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Minimum Value:     processed 1 time
   Maximum Value:     processed 9999 times
   Data Source:       PCF
   Description: >
    An indication of what reprocessing has been performed on the granule.

 - Metadata Name:     ReprocessingPlanned
   Mandatory:         T
   Data Type:         VA45
   Number of Values:  1
   Valids:            no further update anticipated, further update anticipated, further update anticipated using enhanced PGE
   Data Source:       DP
   Description:       Actual is "further update is anticipated".

 - Metadata Name:     ScienceQualityFlag
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Valids:            Passed,Failed,Being Investigated,Not Investigated,Inferred Passed,Inferred Failed,Suspect
   Data Source:       DP
   Description:       Actual is "Not Investigated".

 - Metadata Name:     ScienceQualityFlagExplanation
   Mandatory:         T
   Data Type:         VA255
   Number of Values:  1
   Valids:            Not applicable (free format).
   Data Source:       DP
   Description:       >
    An explanation of the criteria used to set the science quality flag
    should go here.

 - Metadata Name:     ShortName
   Mandatory:         T
   Data Type:         VA8
   Number of Values:  1
   Valids:            OMH2O
   Data Source:       MCF
   Description:       Actual is "OMH2O".

 - Metadata Name:     SizeMBECSDataGranule
   Mandatory:         F
   Data Type:         LF
   Number of Values:  1
   Minimum Value:     0.00e+00
   Maximum Value:     1.00e+04
   Data Source:       DSS
   Description: >
    The volume of data contained in the granule in Mb (this Metadata
    will not appear in the granule).

 - Metadata Name:     VersionID
   Mandatory:         T
   Data Type:         SI
   Number of Values:  1
   Minimum Value:     000
   Maximum Value:     999
   Data Source:       MCF
   Description:       Actual is 1.


Product Specific Attributes:

 - Metadata Name:     EndBlockNr
   Mandatory:         T
   Data Type:         SI
   Number of Values:  1 to 500
   Minimum Value:     1
   Maximum Value:     50
   Data Source:       L1B
   Description:       The number of the NOSE end block along the track.

 - Metadata Name:     ExpeditedData
   Mandatory:         T
   Data Type:         VA10
   Number of Values:  1
   Valids:            TRUE,FALSE
   Data Source:       L1B
   Description:       The indicator for expedited L0 data.

 - Metadata Name:     ExposureTimes
   Mandatory:         T
   Data Type:         F
   Number of Values:  1 to 256
   Minimum Value:     0.0
   Maximum Value:     2000.0
   Data Source:       L1B
   Description:       >
    An array containing the exposure times in seconds used for the
    measurements.

 - Metadata Name:     InstrumentConfigurationIDs
   Mandatory:         T
   Data Type:         SI
   Number of Values:  1 to 256
   Minimum Value:     0
   Maximum Value:     255
   Data Source:       L1B
   Description:       >
    An array containing the instrument configuration identifiers used
    for the measurements.

 - Metadata Name:     MasterClockPeriods
   Mandatory:         T
   Data Type:         F
   Number of Values:  1 to 128
   Minimum Value:     0.0
   Maximum Value:     10.0
   Data Source:       L1B
   Description:       >
    An array containing the master clock periods in seconds used for
    the measurements.

 - Metadata Name:     NrEarthMeasurements
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       >
    The number of earth measurements in the granule (per output product).

 - Metadata Name:     NrMeasurements
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       >
    The number of measurements in the granule (per output product).

 - Metadata Name:     NrSolarMeasurements
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       >
    The number of solar measurements in the granule (per output product).

 - Metadata Name:     NrSpatialZoom
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       The number of measurements in spatial zoom mode.

 - Metadata Name:     NrSpectralZoom
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       The number of measurements in spectral zoom mode.

 - Metadata Name:     NrZoom
   Mandatory:         T
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     9999
   Data Source:       L1B
   Description:       The number of measurements in zoom modes.

 - Metadata Name:     QAStatPctGeolocationErrorVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS measurements for which the geolocation determination
    resulted in the GroudPixelQualityFlag for geolocation error being set.
    (Note the decrepancy of the field definition compared to Section 8.4
    of the GDPS IODS Vol2 document, where this field is defined as not
    being split up for the single OMI channels.)

 - Metadata Name:     QAStatPctMeasErrorVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS measurements with at least one of the following
    error flags set: the alternative engineering data flag, the 
    co-adder error flag and the geolocation error flag.

 - Metadata Name:     QAStatPctMeasWarningVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS measurements for which at least one of the 
    MeasurementQualityFlags was set as a warning, excluding the
    alternative engineering data flag, the co-adder error flag 
    and the geolocation error flag in the count.

 - Metadata Name:     QAStatPctPixBadVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS image pixels with at least one of the following
    PixelQualityFlags set to indicate a bad pixel: the saturated ADC
    flag and the dead pixel flag.

 - Metadata Name:     QAStatPctPixWarningVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS image pixels with at least one of the following
    PixelQualityFlags set as a warning: transient pixel, RTS pixel, 
    saturation possibility, noise calculation, dark current, offset,
    exposure smear and stray light.

 - Metadata Name:     QAStatPctProcessingErrorVIS
   Mandatory:         F
   Data Type:         I
   Number of Values:  1
   Minimum Value:     0
   Maximum Value:     100
   Data Source:       L1B
   Description:       >
    Percentage of VIS image pixels with the processing error flag set.

 - Metadata Name:     PathNr
   Mandatory:         T
   Data Type:         I
   Number of Values:  1 to 500
   Minimum Value:     1
   Maximum Value:     466
   Data Source:       L1B
   Description:       Number of the NOSE path within the repeat cycle.

 - Metadata Name:     SolarEclipse
   Mandatory:         T
   Data Type:         VA10
   Number of Values:  1
   Valids:            TRUE,FALSE
   Data Source:       L1B
   Description:       >
    The indicator that during part of the measurements a solar eclipse
    occurred.

 - Metadata Name:     SouthAtlanticAnomalyCrossing
   Mandatory:         T
   Data Type:         VA10
   Number of Values:  1
   Valids:            TRUE,FALSE
   Data Source:       L1B
   Description:       >
    The indicator that during part of the measurements the spacecraft
    was in the SAA.

 - Metadata Name:     SpacecraftManeuverFlag
   Mandatory:         T
   Data Type:         VA10
   Number of Values:  1
   Valids:            TRUE,FALSE,UNKNOWN
   Data Source:       L1B
   Description:       >
    The indicator that during part of the measurements the spacecraft
    was performing a maneuver.

 - Metadata Name:     StartBlockNr
   Mandatory:         T
   Data Type:         SI
   Number of Values:  1 to 500
   Minimum Value:     1
   Maximum Value:     50
   Data Source:       L1B
   Description:       Number of the NOSE start block along the track.

Archived Metadata:

 - Metadata Name:     ESDTDescriptorRevision
   Mandatory:         T
   Data Type:         VA20
   Number of Values:  1
   Minimum Value:     0.0.0
   Maximum Value:     9.9.99
   Data Source:       MCF
   Description:       >
    The version of the ESDT descriptor file as determined by ECS.

 - Metadata Name:     LongName
   Mandatory:         T
   Data Type:         VA80
   Number of Values:  1
   Valids:            OMI/Aura Formaldehyde (H2O) Total Column 1-Orbit L2 Swath 13x24km
   Data Source:       MCF
   Description:       >
    Actual is
    "OMI/Aura Water Vapor (H2O) Total Column 1-Orbit L2 Swath 13x24km"
    (see Section 7.0 of Reference 2).

References: >

  1. "OMI Algorithm Theoretical Basis Document, Volume IV, OMI Trace Gas Algorithms"
     (OMI-ATBD-VOL4, ATBD-OMI-04, Version 2.0, August 2002)

  2. "HDF-EOS Aura File Format Guidelines"
     (OMI-AURA-DATA-GUIDE, Version 1.3, 16 October 2003)

  3. "OMI Science Software Delivery Guide for Version 0.9"
     (OMI-SSDG-0.9.8, Version 0.9.8, 14 August 2003)

  4. "OMI GDPS Input/Output Data Specification (IODS) Volume 2"
     (OMI-GDPS-IODS-2, SD-OMIE-7200-DS-467, 9 April 2003)

  5. "Release 6A Implementation Earth Science Data Model for the ECS Project"
     (420-TP-022-002, June 2001)
     (http://edhs1.gsfc.nasa.gov/waisdata/rel6/html/tp4202202.html and
      http://edhs1.gsfc.nasa.gov/waisdata/rel6/html/tp42022_adds.html)

  6. "OMI L2 - L4 Metadata Reference Guide"
     (3 July 2002)
     (https://omiwww.gsfc.nasa.gov/mlinda/OMImetadataRefGuide.html)
