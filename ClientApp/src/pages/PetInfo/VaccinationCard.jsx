<<<<<<< HEAD
import React from 'react'

const VaccinationCard = () => {
    return (
        <>
            <div className='ml-4 mt-28 w-[360px] h-[50px] flex justify-between '>
                <h1 className='text-[18px] font-bold'>Carnet de vacunación</h1>
                <button className="text-primary-100 border-2 border-primary-100 rounded-lg  w-[120px] h-[33px] text-[16px] ">
                    Ver Completo
                </button>
            </div>
            <div className=' h-[120px] w-[373px] bg-secondary-50 ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg'>
                <h1 className='font-bold ml-5 mt-2'>{"{nombre de vacuna}"}</h1>
                <p className='ml-5  text-[13px]'>Lote:{"{numero}"}</p>
                <p className='ml-5 text-[13px]'>Fecha de vacunacion:{"{fecha}"}</p>
                <p className='ml-5 text-[13px]'>Proxima vacunacion:{"{fecha}"}</p>
            </div>
            <p className="text-gray-150 text-[11px] md:text-start ml-24 text-end mt-2 mb-10 mr-2">ACTUALIZADO POR"{"NOMBRE DE LA CLINICA"} EL 21/2/23"</p>
        </>
    )
}

export default VaccinationCard
=======
import React from "react";

import { myFecha } from "../../utils/fecha";

const VaccinationCard = ({ vacuna }) => {
  return (
    <div className="w-full flex flex-col gap-1">
      <div className="bg-secondary-50 ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg p-4">
        <h1 className="font-bold ml-5 mt-2">{vacuna.nombre}</h1>
        <p className="ml-5 text-[13px]">
          Fecha de aplicación: {myFecha(vacuna.fechaAplicacion)}
        </p>
        <p className="ml-5  text-[13px]">Lote: {vacuna.loteSerial}</p>
        <p className="ml-5  text-[13px]">
          Próxima Aplicación: {myFecha(vacuna.proximaAplicacion)}
        </p>
      </div>
      <p className=" text-[11px] md:text-start ml-24 text-end mt-2 mb-10 mr-2 md:ml-60 text-black">
        ACTUALIZADO EL {myFecha(vacuna.fechaAplicacion)}
      </p>
    </div>
  );
};

export default VaccinationCard;
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
