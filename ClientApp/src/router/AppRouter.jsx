import React from "react";
import { Routes, Route } from "react-router-dom";

// components
import Home from "../pages/Home";
import { Clinic } from "../pages/Clinic";
import { AddPet } from "../pages/AddPet";
import PetInfo from "../pages/PetInfo/PetInfo";
import HomeVet from "../pages/HomeVet/HomeVet";
import PetVet from "../pages/PetVet/PetVet";
import PetInfoVet from "../pages/PetInfoVet/PetInfoVet";
import PetInfoVet2 from "../pages/PetInfoVet/petInfoVet2";

export function AppRouter() {
  return (
    <>
      <Routes>
        <Route path="/home" element={<Home />} />
        <Route path="/clinic/:id" element={<Clinic />} />
        <Route path="/petinfo/:id" element={<PetInfo />} />
        <Route path="/add-mascot" element={<AddPet />} />
        <Route path="/veterinary" element={<HomeVet />} />
        <Route path="/propvet/:id" element={<PetVet />} />
        <Route path="/petinfovet/:id" element={<PetInfoVet2 />} />
      </Routes>
    </>
  );
}
