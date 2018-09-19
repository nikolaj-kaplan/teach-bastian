<template>
  <div>
      <toilet v-for="toilet in toilets" v-bind:key="toilet.id" v-bind:toilet="toilet"></toilet>
  </div>
</template>

<script>
/* eslint-disable */
import Toilet from './Toilet';
export default {
  components: {
    Toilet,
  },
  name: 'toilet-test',
  data () {
    return {
      toilets: [{id:1},{id:2},{id:3}]
    }
  },
  methods: {
  }
}
/* eslint-enable */
</script>
