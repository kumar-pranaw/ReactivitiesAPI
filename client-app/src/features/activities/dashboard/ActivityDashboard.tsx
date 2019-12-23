import React from 'react'
import {Grid, List, GridColumn} from 'semantic-ui-react';
import { IActivity } from '../../../app/model/activity';
import ActivityList from './ActivityList';
import ActivityDetails from '../details/ActivityDetails';

interface IProps {
    activities: IActivity[]
}

const ActivityDashboard: React.FC<IProps> = ({activities}) => {
    return (
      <Grid>
          <Grid.Column width= {10}>
              <ActivityList activities = {activities}/>
          </Grid.Column>
          <GridColumn width = {6}>
            <ActivityDetails></ActivityDetails>
          </GridColumn>
      </Grid>
    )
}

export default ActivityDashboard