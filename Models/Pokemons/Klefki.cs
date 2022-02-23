using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Klefki Specie to store common natural stats of every {'abilities': ['prankster', 'magician'], 'base_experience': 165, 'height': 2, 'id': 707, 'moves': ['cut', 'tackle', 'hyper-beam', 'thunder-wave', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'rest', 'substitute', 'thief', 'snore', 'protect', 'spikes', 'lock-on', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'torment', 'facade', 'magic-coat', 'recycle', 'imprison', 'secret-power', 'astonish', 'metal-sound', 'iron-defense', 'covet', 'calm-mind', 'heal-block', 'last-resort', 'magnet-rise', 'switcheroo', 'giga-impact', 'mirror-shot', 'flash-cannon', 'psyshock', 'magic-room', 'foul-play', 'round', 'draining-kiss', 'crafty-shield', 'play-rough', 'fairy-wind', 'fairy-lock', 'confide', 'dazzling-gleam'], 'name': 'klefki', 'stats': {'hp': 57, 'attack': 80, 'defense': 91, 'special-attack': 80, 'special-defense': 87, 'speed': 75}, 'types': ['steel', 'fairy'], 'weight': 30, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'gray', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'fast', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'クレッフィ', 'ko': '클레피', 'zh-Hant': '鑰圈兒', 'fr': 'Trousselin', 'de': 'Clavion', 'es': 'Klefki', 'it': 'Klefki', 'en': 'Klefki', 'ja': 'クレッフィ', 'zh-Hans': '钥圈儿'}, 'genera': {'ja-Hrkt': 'かぎたばポケモン', 'ko': '열쇠꾸러미포켓몬', 'zh-Hant': '鑰匙串寶可夢', 'fr': 'Pokémon Trousseau', 'de': 'Schlüssel', 'es': 'Pokémon Llavero', 'it': 'Pokémon Portachiavi', 'en': 'Key Ring Pokémon', 'ja': 'かぎたばポケモン', 'zh-Hans': '钥匙串宝可梦'}}
	public class SpecieKlefki : PokemonSpecie
	{
#nullable enable
		private static SpecieKlefki? _instance = null;
#nullable restore
        public static SpecieKlefki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKlefki();
                }
                return _instance;
            }
        }

		public SpecieKlefki() : base(
			"Klefki",
			57, // HPs
			80, 91, // Attack & Defense
			80, 87, // Special Attack & Defense
			75			
		) {}
	}


	//Klefki Pokemon Class
	public class Klefki : Pokemon
	{

		public Klefki(string nickname, int level) : base(
			707,
			SpecieKlefki.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Fairy.Instance			
		) {}

		public Klefki() : base(
			707,
			SpecieKlefki.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
	}
}