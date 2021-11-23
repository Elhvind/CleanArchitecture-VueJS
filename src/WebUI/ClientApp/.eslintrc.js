// https://eslint.org/docs/6.0.0/rules/
module.exports = {
  root: true,
  env: {
    node: true
  },
  extends: [
    'plugin:vue/essential',
    '@vue/standard'
  ],
  parserOptions: {
    parser: 'babel-eslint'
  },
  rules: {
    'no-console': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    'no-debugger': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    'indent': ['warn', 2, { 'SwitchCase': 1 }],
    //'vue/script-indent': ['error', 2, {
    //  'baseIndent': 0,
    //  'switchCase': 0,
    //  'ignores': []
    //}]
  }
}
