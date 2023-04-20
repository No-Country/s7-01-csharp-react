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
