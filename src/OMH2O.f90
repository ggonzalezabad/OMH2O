PROGRAM OMH2O

  ! --------------------------------------------------------- !
  !                                                           !
  ! OMH2O wrapper for OMSAO_main, the "real" main program of !
  ! the SAO PGEs, located in the shared source directory.     !
  !                                                           !
  ! --------------------------------------------------------- !

  USE OMSAO_precision_module, ONLY: i4
  IMPLICIT NONE

  INTEGER (KIND=i4) :: exit_value

  CALL OMSAO_main ( exit_value )

  CALL EXIT (exit_value)
  STOP


END PROGRAM OMH2O
