import React, { useEffect, useState } from "react";
import { CaretLeft } from "@phosphor-icons/react";

import { useMatch, useNavigate } from "react-router-dom";

// redux
import { useSelector } from "react-redux";

import { Button } from "../common";

import Logo from "../../assets/images/Logo.svg";

const Navbar = () => {
  const match = useMatch("/");
  const navigate = useNavigate();

  const fotoPerfil = useSelector((state) => state.fotoPerfil);
  // console.log("🚀 ~ file: Navbar.jsx:20 ~ Navbar ~ userId:", userId);

  const handleBack = () => {
    console.log("click");
    navigate(-1);
  };

  return (
    <nav className="mx-auto flex justify-between w-full p-4 bg-white">
      {match ? (
        <div className="text-2xl cursor-pointer">
          <img src={Logo} alt="Logo" className="w-[130px] h-[32] mt-2 ml-2 " />
        </div>
      ) : (
        <Button
          click={handleBack}
          className="w-24"
          text={
            <div className="flex flex-row justify-center items-center gap-2 px-6">
              <CaretLeft size={16} color="#474747" weight="bold" />
              <p>Atras</p>
            </div>
          }
        />
      )}

      <div className="cursor-pointer">
        <img
          src={fotoPerfil}
          alt="profilePic"
          className="w-8 h-8 rounded-full mt-2 mr-2"
        />
      </div>
    </nav>
  );
};

export default Navbar;
