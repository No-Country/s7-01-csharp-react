import React from 'react'
import { MagnifyingGlass } from '@phosphor-icons/react'

const FirstBlock = () => {
    return (
        <div className='mt-4'>
            <h3 className='ml-2 text-[18px] font-bold'>Agregar Paciente</h3>
            <p className='ml-2 text-[13px] text-gray-150 mt-4'>Busca el DNI del dueño de la mascota para poder agregar un nuevo paciente</p>
            <div className="ml-2 mt-4 w-[328px] h-[40px] md:w-[900px] md:h-[21px] rounded-xl  flex items-center gap-2">
                <MagnifyingGlass size={20} />
                <input
                    type="text"
                    className=" w-[280px] h-[21px] md:w-[900px] md:h-[21px] rounded-md p-4 "
                    placeholder="Buscar paciente por DNI"
                />
            </div>
        </div>)
}

export default FirstBlock