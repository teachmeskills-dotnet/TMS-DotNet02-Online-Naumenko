import React from "react";
import MainSection from "../components/Sections/MainSection/MainSection";
import PopularSection from "../components/Sections/PopularSection/PopularSection";
import RecommendedSection from "../components/Sections/RecommendedSection/RecommendedSection";

const news = [
  {
  id: 1,
  title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
  link: 'https://test.test',
  date: 'Вчера, 21:31',
  views: 10,
  },
  {
  id: 2,
  title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
  link: 'https://test.test',
  date: 'Вчера, 21:32',
  views: 10,
  },
  {
  id: 3,
  title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
  link: 'https://test.test',
  date: 'Вчера, 21:33',
  views: 10,
  },
  {
  id: 4,
  title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
  link: 'https://test.test',
  date: 'Вчера, 21:34',
  views: 10,
  },
//   {
//   id: 5,
//   title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
//   link: 'https://test.test',
//   date: 'Вчера, 21:33',
//   views: 10,
//   },
//   {
//   id: 6,
//   title: 'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала',
//   link: 'https://test.test',
//   date: 'Вчера, 21:34',
//   views: 10,
//   },
];

//const [SocialShareWindowIsVisible, setSocialShareWindowIsVisible] = useState(false);

const handleToggle = () => {
  //setSocialShareWindowIsVisible(!SocialShareWindowIsVisible);
};
const Home = () => {
return (
    <main>
        <div className="container">
            <MainSection sectionName={'Главное'} handleToggle={handleToggle} posts={news}/>
            <PopularSection sectionName={'Популярное'} handleToggle={handleToggle} posts={news}/>
            {/* <RecommendedSection sectionName={'Популярное'} handleToggle={handleToggle} posts={news}/> */}
        </div>
          {/* <SocialShareWindow visible={SocialShareWindowIsVisible}/> */}
    </main>
);
};

export default Home;