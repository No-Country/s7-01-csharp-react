<<<<<<< HEAD
import React from "react";
import { MagnifyingGlass } from "@phosphor-icons/react";

const FirstBlock = () => {
  return (
    <div className="mt-4">
=======
import React, { useEffect, useState } from "react";
import { MagnifyingGlass } from "@phosphor-icons/react";
import { Link } from "react-router-dom";
import { getAllPropietaries } from "../../services/getAllPropietaries";

const FirstBlock = () => {
  const [Propietaries, setPropietaries] = useState();
  const [ResultSearch, setResultSearch] = useState([]);
  const [isFocus, setisFocus] = useState(false);
  const handleChange = (e)=>{
    let search = Propietaries.filter(p => p.dni.includes(e.target.value))
    setResultSearch(search)
  }

  const getApi = async ()=>{
    let response = await getAllPropietaries();
    setPropietaries(response)
  }

  const handleFocus = (e)=>{
    setisFocus(!isFocus)
  }

  useEffect(() => {
    getApi()
    
  }, []);
  return (
    <div className="mt-4" onBlur={handleFocus}>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
      <h3 className="ml-2 text-[18px] font-bold">Agregar Paciente</h3>
      <p className="ml-2 text-[13px] text-gray-150 mt-4">
        Busca el DNI del dueño de la mascota para poder agregar un nuevo
        paciente
      </p>
      <div className="ml-2 mt-4 w-[328px] h-[40px] md:w-[900px] md:h-[21px] rounded-xl  flex items-center gap-2">
<<<<<<< HEAD
        <MagnifyingGlass size={20} />
        <input
          type="text"
          className=" w-[280px] h-[21px] md:w-[900px] md:h-[21px] rounded-md p-4 "
          placeholder="Buscar paciente por DNI"
        />
      </div>
=======
        <Link to="/app/propvet">
        <MagnifyingGlass size={20}/>
        </Link>
        <input
          type="text"
          className=" w-[280px] h-[21px] md:w-[900px] md:h-[21px] rounded-md p-4 "
          placeholder="Buscar Propietario por DNI"
          onChange={handleChange}

        />
      </div>
      {ResultSearch.length > 0 && <div className="ml-2 mt-2 w-[328px] h-[120px] md:w-[900px] md:h-[240px] rounded-xl p-2 overflow-y-scroll">
        { ResultSearch.map((result) => (
          <Link to={`/app/propvet/${result.id}`} key={result.id} className="mb-2 z-10" onMouseOver={()=> setisFocus(true)}>
            <p className="text-[14px] font-semibold">{result.nombre}</p>
            <p className="text-[12px]">{result.dni}</p>
          </Link>
        ))}
      </div>}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
    </div>
  );
};

export default FirstBlock;
