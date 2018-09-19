<template>
    <div>
        <h1>Toilet {{toilet.id}} </h1>
        {{smell}}
        <button @click="big()">big</button>
    </div>
</template>

<script>
/* eslint-disable */
export default {
    name: 'toilet',
    props: ['toilet'],
    data() {
        return {
            smell: 0
        }
    },
    methods: {
        big() {
            this.smell = 10;
            this.ventilate()
        },
        ventilate() {
            if (this.smell == 0) {
                return;
            }
            this.smell--;
            setTimeout(this.ventilate, 1000)
        }
    }
}
/* eslint-enable */
</script>
