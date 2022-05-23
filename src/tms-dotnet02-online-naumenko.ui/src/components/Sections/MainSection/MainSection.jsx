import React, {useState} from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import { useNavigate } from "react-router-dom";

const MainSection = (props) => {

    const [test, setTest] = useState('');

    const router = useNavigate();
    
    const url = 'https://localhost:5001/posts?title=My&termIds=1';

    const fetchData = async () => {
        try {
          const response = await fetch(url, {
            method: 'GET'});
          const json = await response.json();
          setTest(json[0]);
        } catch (error) {
          console.log("error", error);
        }
      };
      fetchData();
    
    console.log(test);
    const handleTogglePost = () => {
        router(`/posts/${test.title}`)
      };
    return (
        <section className="section-main pt__3">
            <div className="row g__3">
                <div className="col-md-6 col-lg-5 col-xl-5">
                    <PostWithBackgroud 
                    handleToggle={props.handleToggle} 
                    link={() => router(`/${test.date}/${test.slug}`)} 
                    title={test.title} 
                    date={test.date} 
                    views={10} 
                    background={bgimage}
                    height='lg'/>
                </div>
                <div className="col-md-6 col-lg-4 col-xl-3">
                    <PostList 
                    sectionName={props.sectionName}
                    handleToggle={props.handleToggle} 
                    posts={props.posts}/>
                </div>
                <div className="col-md-12 col-lg-3 col-xl-4">
                    <div className="row g__3">
                        <div className="col-md-6 col-lg-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={'https://test.test'} 
                            title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                            date={'Вчера, 21:34'} 
                            views={10} 
                            background={bgimage}
                            height='sm'/>
                        </div>
                        <div className="col-md-6 col-lg-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={'https://test.test'} 
                            title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                            date={'Вчера, 21:34'} 
                            views={10} 
                            background={bgimage}
                            height='sm'/>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default MainSection;