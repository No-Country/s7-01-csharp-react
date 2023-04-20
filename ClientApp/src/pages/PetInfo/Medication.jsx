import React from "react";

const Medication = () => {
  return (
    <div className="w-full flex flex-col gap-1">
      <div className=" h-[120px] ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg bg-white">
        <h1 className="font-bold ml-5 mt-2">{"{tipo de tratamiento}"}</h1>
        <p className="ml-5  text-[13px]">Fecha de inicio:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]">Fecha de finalización:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]"> Próxima vacunación:{"{fecha}"}</p>
      </div>
      <p className="text-black text-[11px] text-end mt-2 mb-10 mr-2 md:text-start md:ml-60">
        ACTUALIZADO EL 21/2/23
      </p>
    </div>
  );
};

export default Medication;
