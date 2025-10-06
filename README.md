# shave.github.io

A static site / demo for the **Shave** JavaScript plugin — a zero-dependency utility to truncate multi-line text to a given height with ellipsis or custom characters.

This serves as the GitHub Pages / documentation / demo page for the `shave` plugin.

## Table of Contents

- [About](#about)  
- [Demo / Usage Examples](#demo--usage-examples)  
- [Installation](#installation)  
- [API / Options](#api--options)  
- [How It Works](#how-it-works)  
- [Contributing](#contributing)  
- [License](#license)  

---

## About

**Shave** is a lightweight JavaScript plugin (≈ 1.5 KB unminified) that truncates multi-line text inside an element to a maximum height. After truncation, it preserves the full text in a hidden span so the original content remains intact behind the scenes.  
It doesn’t depend on any library (vanilla JS) and works with custom ellipsis characters and CSS class names.  
More info: the plugin’s GitHub repo is [dollarshaveclub/shave] :contentReference[oaicite:0]{index=0}

## Demo / Usage Examples

On this site you can see:

- Live examples where long paragraphs are truncated based on container height  
- Custom ellipsis / truncation characters  
- Styling with CSS  
- Interaction (e.g. re-shaving on window resize)  

Feel free to inspect the source to see how the demo pages are built.

## Installation

You can install **shave** for use in your projects by:

```bash
npm install shave --save
