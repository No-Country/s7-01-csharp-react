import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import PetCard from './PetCard'
import RememberCards from '../Home/RememberCards'
import ClinicHistory from './ClinicHistory'
import VaccinationCard from './VaccinationCard'
import Medication from './Medication'



const PetInfo = () => {
  return (
    <>
      <Navbar/>
      <PetCard/>
      <RememberCards/>
      <ClinicHistory/>
      <VaccinationCard/>
      <Medication/>  
    </>
  )
}

export default PetInfo