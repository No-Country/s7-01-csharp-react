import Navbar from "../../components/Layouts/Navbar";
import RememberCards from "./RememberCards";
import ClinicCard from "./ClinicCard";
import ShowPets from "./ShowPets";

const Home = () => {
  return (
    <>
      <Navbar />
      <ShowPets />
      <RememberCards />
      <ClinicCard />
    </>
  );
};

export default Home;
