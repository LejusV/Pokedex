using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Espeon Specie to store common natural stats of every {'abilities': ['synchronize', 'magic-bounce'], 'base_experience': 184, 'height': 9, 'id': 196, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'psybeam', 'hyper-beam', 'dig', 'toxic', 'confusion', 'psychic', 'quick-attack', 'mimic', 'double-team', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'morning-sun', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'trick', 'magic-coat', 'skill-swap', 'secret-power', 'hyper-voice', 'signal-beam', 'covet', 'calm-mind', 'natural-gift', 'power-swap', 'last-resort', 'giga-impact', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'magic-room', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide', 'dazzling-gleam', 'baby-doll-eyes'], 'name': 'espeon', 'stats': {'hp': 65, 'attack': 65, 'defense': 60, 'special-attack': 130, 'special-defense': 95, 'speed': 110}, 'types': ['psychic'], 'weight': 265, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'purple', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'エーフィ', 'roomaji': 'Eifie', 'ko': '에브이', 'zh-Hant': '太陽伊布', 'fr': 'Mentali', 'de': 'Psiana', 'es': 'Espeon', 'it': 'Espeon', 'en': 'Espeon', 'ja': 'エーフィ', 'zh-Hans': '太阳伊布'}, 'genera': {'ja-Hrkt': 'たいようポケモン', 'ko': '태양포켓몬', 'zh-Hant': '太陽寶可夢', 'fr': 'Pokémon Soleil', 'de': 'Sonne', 'es': 'Pokémon Sol', 'it': 'Pokémon Sole', 'en': 'Sun Pokémon', 'ja': 'たいようポケモン', 'zh-Hans': '太阳宝可梦'}}
	public class SpecieEspeon : PokemonSpecie
	{
#nullable enable
		private static SpecieEspeon? _instance = null;
#nullable restore
        public static SpecieEspeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEspeon();
                }
                return _instance;
            }
        }

		public SpecieEspeon() : base(
			"Espeon",
			65, // HPs
			65, 60, // Attack & Defense
			130, 95, // Special Attack & Defense
			110			
		) {}
	}


	//Espeon Pokemon Class
	public class Espeon : Pokemon
	{

		public Espeon(string nickname, int level) : base(
			196,
			SpecieEspeon.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Espeon() : base(
			196,
			SpecieEspeon.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}