import React from 'react'

<<<<<<< HEAD
const SecondBlock = () => {
  return (
    <div className='mt-4 bg-gray-50'>
        <h3 className='ml-2 mt-2 text-[18px] font-bold'>Mascotas de "{"{nombre del dueño}"}"</h3>
=======
const SecondBlock = ({nombre}) => {
  return (
    <div className='mt-10 bg-gray-50'>
        <h3 className='ml-2 mt-2 text-[18px] font-bold'>Mascotas de "{nombre}"</h3>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
        <p className='mt-2 ml-2 text-[13px] text-gray-150'>Selecciona cual de sus mascotas sera tu nuevo paciente</p>

    </div>
  )
}

export default SecondBlock