import React from "react";

const VaccinationCard = () => {
  return (
    <div className="w-full flex flex-col gap-1">
      <div className=" h-[120px] bg-secondary-50 ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg">
        <h1 className="font-bold ml-5 mt-2">{"{nombre de vacuna}"}</h1>
        <p className="ml-5  text-[13px]">Lote:{"{numero}"}</p>
        <p className="ml-5 text-[13px]">Fecha de vacunacion:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]">Proxima vacunacion:{"{fecha}"}</p>
      </div>
      <p className=" text-[11px] md:text-start ml-24 text-end mt-2 mb-10 mr-2 md:ml-60 text-black">
        ACTUALIZADO EL 21/2/23
      </p>
    </div>
  );
};

export default VaccinationCard;
