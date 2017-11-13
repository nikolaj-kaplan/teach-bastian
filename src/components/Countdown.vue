<template>
  <div>
    <!-- hvor mange sekunder skal vi tælle til? -->
    Hvor mange sekunder? <input style='font-size:30px; width: 50px;' type='text' v-model='seconds'>
    <b-progress :value="progress" :max="max" show-progress animated></b-progress>
    Vi skal have en knap til at starte<br>
    Og vise progress som tal også?
  </div>
</template>

<script>
/* eslint-disable */
export default {
  name: 'countdown',
  data () {
    return {
      progress: 10,
      max: 100,
      seconds: 0,
      startTime: undefined,
      running: false
    }
  },
  methods: {
    start () {
      this.startTime = new Date().getTime()
      this.updateProgress()
    },
    updateProgress () {
      var now = new Date().getTime()
      /* this.progress skal opdateres */
      if (true/* when to stop?*/) {
        return
      }
      // her genstarter vi ved at sætte et timeout, der kalder samme funktion igen om 100 ms
      setTimeout(this.updateProgress, 100)
    }
  }
}
/* eslint-enable */
</script>
