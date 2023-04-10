import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import RememberCards from '../Home/RememberCards'
import ClinicHistory from './ClinicHistory'

import PetCard from './PetCard'

const PetInfo = () => {
  return (
    <>
      <Navbar/>
      <PetCard/>
      <RememberCards/>
      <ClinicHistory/>

      
  
    </>
  )
}

export default PetInfo