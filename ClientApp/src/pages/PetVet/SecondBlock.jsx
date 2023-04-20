import React from 'react'

const SecondBlock = ({nombre}) => {
  return (
    <div className='mt-10 bg-gray-50'>
        <h3 className='ml-2 mt-2 text-[18px] font-bold'>Mascotas de "{nombre}"</h3>
        <p className='mt-2 ml-2 text-[13px] text-gray-150'>Selecciona cual de sus mascotas sera tu nuevo paciente</p>

    </div>
  )
}

export default SecondBlock