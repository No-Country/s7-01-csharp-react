import React, { useEffect, useState } from "react";
import { PawPrint } from "@phosphor-icons/react";
import imgPerro from "../../assets/images/imgPerro.png";
import imgPerro2 from "../../assets/images/imgPerro2.png";
import imgPerro3 from "../../assets/images/imgPerro3.png";

// Rutas
import { Link } from "react-router-dom";

// redux
import { useSelector } from "react-redux";

// services
import { getMascotByUser } from "../../services/mascot";

const ShowPets = () => {
  const idUser = useSelector((state) => state.userId);
  const [mascots, setMascots] = useState([]);

  useEffect(() => {
    getmascot(idUser && idUser);
  }, []);

  const getmascot = async (id) => {
    try {
      // console.log(id);
      // console.log("cargando mascota");
      const response = await getMascotByUser(id);
      // console.log(
      //   "🚀 ~ file: ShowPets.jsx:27 ~ getmascot ~ response:",
      //   response.result
      // );

      setMascots(response.result);
    } catch (error) {
      console.log(error);
    }
  };

  // console.log(mascots);

  return (
    <div className="container mx-auto">
      <div className="mt-4 p-2 bg-gray-50">
        <h3 className="ml-2 text-[18px] font-bold">
          Mis Mascotas({mascots.length})
        </h3>
      </div>
      <div className="mt-6 flex w-full justify-around">
        <Link to={`/app/add-mascot`}>
          <div className="relative">
            <div className="h-16 w-16 rounded-full border bg-gray-100 hover:border-purple-700">
              <PawPrint size={28} className="absolute left-4 top-4" />
            </div>
            <p className="text-center">Agregar</p>
            <p className="text-center">Mascota</p>
          </div>
        </Link>
        {mascots.map((mascot) => (
          <Link key={mascot.id} to={`/app/petInfo/${mascot.id}`}>
            <div className="">
              <img
                src={mascot.urlFotoPerfil}
                alt="perro"
                className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
              />
              <p className="text-center">{mascot.nombre}</p>
            </div>
          </Link>
        ))}

        {/* <div className="">
          <img
            src={imgPerro2}
            alt="perro"
            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
          />
          <p className="text-center">{"Mascota"}</p>
        </div>
        <div className="">
          <img
            src={imgPerro3}
            alt="perro"
            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
          />
          <p className="text-center">{"Mascota"}</p>
        </div> */}
      </div>
      <div />
    </div>
  );
};

export default ShowPets;
