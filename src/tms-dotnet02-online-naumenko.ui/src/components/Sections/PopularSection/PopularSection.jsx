import React, { useState } from 'react';
import PostList from '../../Posts/PostList/PostList';
import PostWithBackgroud from '../../Posts/PostWithBackground/PostWithBackground';
import bgimage from '../../Posts/avatar.jpeg';
import PostAuthorOpinion from '../../Posts/PostAuthorOpinion/PostAuthorOpinion';
import { useNavigate } from 'react-router-dom';
import PostsData from '../MainSection/PostsData';

const PopularSection = (props) => {

    const [posts, setPosts] = useState([]);

    const getPosts = (posts) => {
        setPosts(posts);
    }

    const router = useNavigate();

    return (
        <section className="section-main pt__3">
            <PostsData posts={getPosts} getAll={true}/>
            <div className="row g__3">
                <div className="col-md-6 col-lg-4 col-xl-3">
                    <PostList
                    sectionName={props.sectionName}
                    handleToggle={props.handleToggle} 
                    posts={posts}/>
                </div>
                <div className="col-md-6 col-lg-8 col-xl-6">
                    <div className="row g__3">
                        <div className="col-md-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={() => router(`/2022-04-19T00:00:00/norways-energy-sales-growth-spurs-accusations-of-profiting-from-war-demands-for-help/11`)} 
                            title={"Norway's energy sales growth spurs accusations of profiting from war, demands for help"} 
                            date={'2022-04-19T00:00:00'} 
                            views={10} 
                            background={'https://static.euronews.com/articles/stories/06/73/86/18/773x435_cmsv2_21a9e255-64c6-5f6d-b2b7-6cb91ffd959c-6738618.jpg'}
                            height='sm'/>
                        </div>
                        <div className="col-md-12">
                            <PostWithBackgroud 
                            handleToggle={props.handleToggle} 
                            link={'https://test.test'} 
                            title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                            date={'2022-04-19T00:00:00'} 
                            views={10} 
                            background={bgimage}
                            height='sm'/>
                        </div>
                    </div>
                </div>
                <div className="col-xl-3 d-none d-xl-block">
                     <div className="col-12">
                        <PostWithBackgroud 
                        handleToggle={props.handleToggle} 
                        link={'https://test.test'} 
                        title={'В МВД рассказали о сроках и плюсах добровольной сдачи нелегального арсенала'} 
                        date={'2022-04-19T00:00:00'} 
                        views={10} 
                        background={bgimage}
                        height='lg'/>
                    </div>
                </div>
            </div>
        </section>
    );
};

export default PopularSection;