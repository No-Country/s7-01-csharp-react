import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import FirstBlock from './FirstBlock'
import SecondBlock from './SecondBlock'
import ThirdBlock from './ThirdBlock'

const HomeVet = () => {
  return (
    <div className='container mx-auto w-full h-full'>
      <Navbar/>
      <FirstBlock/>
      <SecondBlock/>    
      <ThirdBlock/>  
    </div>
  )
}

export default HomeVet