import React from 'react'

const VaccinationCard = () => {
    return (
        <>
            <div className='ml-4 w-[360px] h-[50px] flex justify-between '>
                <h1 className='text-[18px] font-bold'>Carnet de vacunación</h1>
                <button className="text-primary-100 border-2 border-primary-100 rounded-lg  w-[120px] h-[33px] text-[16px] ">
                    Ver Completo
                </button>
            </div>
            <div className=' h-[120px] bg-secondary-50 ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg'>
                <h1 className='font-bold ml-5 mt-2'>{"{nombre de vacuna}"}</h1>
                <p className='ml-5  text-[13px]'>Lote:{"{numero}"}</p>
                <p className='ml-5 text-[13px]'>Fecha de vacunacion:{"{fecha}"}</p>
                <p className='ml-5 text-[13px]'>Proxima vacunacion:{"{fecha}"}</p>
            </div>
            <p className="text-gray-150 text-[11px] text-end mt-2 mb-10 mr-2">ACTUALIZADO POR"{"NOMBRE DE LA CLINICA"} EL 21/2/23"</p>
        </>
    )
}

export default VaccinationCard