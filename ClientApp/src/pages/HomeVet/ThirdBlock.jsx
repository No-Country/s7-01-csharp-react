import React from 'react'

const ThirdBlock = () => {
    return (
        <div className='mt-8'>
            <h3 className='font-bold text-[18px] ml-2'>Próximas Citas</h3>            
            <p className='mt-2 ml-2'>No hay citas programadas</p>
            <button className= 'mt-4 ml-2 text-primary-100 border border-primary-100 text-[13px] rounded-xl w-[120] h-[33px] px-3 py-1'>
                Agendar Cita
            </button>
        </div>
    )
}

export default ThirdBlock