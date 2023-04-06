import React from 'react'
import { MagnifyingGlass } from '@phosphor-icons/react'

const ClinicCard = () => {
    return (
        <>
            <div className="mt-8 px-2">
                <h3 className="mt-4 font-bold">Clinicas Veterinarias</h3>
                <div className="mt-4 w-[328px] h-[40px] rounded-xl  flex items-center gap-2">
                    <MagnifyingGlass size={20} />
                    <input type="text" className=" w-[280px] h-[21px]  rounded-md p-4 " placeholder="Buscar Veterinarias" />
                </div>
            </div>
            <div className="mx-auto grid grid-cols-2 gap-4 justify-between mt-4">
                <button className="bg-primary-100 rounded-xl px-2 py-1">
                    Cirugía
                </button>
                <button className="bg-primary-100 rounded-xl px-2 py-1">
                    Vacunas
                </button>
                <button className="bg-primary-100 rounded-xl px-2 py-1">
                    Desparacitacion
                </button>
                <button className="bg-primary-100  rounded-xl px-2 py-1">
                    Atención
                </button>
            </div>

        </>
    )
}

export default ClinicCard