using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Togetic Specie to store common natural stats of every {'abilities': ['hustle', 'serene-grace', 'super-luck'], 'base_experience': 142, 'height': 6, 'id': 176, 'moves': ['mega-punch', 'fly', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'growl', 'flamethrower', 'hyper-beam', 'counter', 'seismic-toss', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'metronome', 'fire-blast', 'swift', 'soft-boiled', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sweet-kiss', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'charm', 'rollout', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'baton-pass', 'encore', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'rock-smash', 'heat-wave', 'facade', 'focus-punch', 'follow-me', 'trick', 'wish', 'magic-coat', 'brick-break', 'yawn', 'endeavor', 'secret-power', 'hyper-voice', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'covet', 'magical-leaf', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'fling', 'last-resort', 'drain-punch', 'giga-impact', 'zen-headbutt', 'defog', 'captivate', 'grass-knot', 'ominous-wind', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bestow', 'work-up', 'fairy-wind', 'confide', 'dazzling-gleam', 'smart-strike'], 'name': 'togetic', 'stats': {'hp': 55, 'attack': 40, 'defense': 85, 'special-attack': 80, 'special-defense': 105, 'speed': 40}, 'types': ['fairy', 'flying'], 'weight': 32, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 1, 'capture_rate': 75, 'color': 'white', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['flying', 'fairy'], 'names': {'ja-Hrkt': 'トゲチック', 'roomaji': 'Togechick', 'ko': '토게틱', 'zh-Hant': '波克基古', 'fr': 'Togetic', 'de': 'Togetic', 'es': 'Togetic', 'it': 'Togetic', 'en': 'Togetic', 'ja': 'トゲチック', 'zh-Hans': '波克基古'}, 'genera': {'ja-Hrkt': 'しあわせポケモン', 'ko': '행복포켓몬', 'zh-Hant': '幸福寶可夢', 'fr': 'Pokémon Bonheur', 'de': 'Freude', 'es': 'Pokémon Felicidad', 'it': 'Pokémon Felicità', 'en': 'Happiness Pokémon', 'ja': 'しあわせポケモン', 'zh-Hans': '幸福宝可梦'}}
	public class SpecieTogetic : PokemonSpecie
	{
#nullable enable
		private static SpecieTogetic? _instance = null;
#nullable restore
        public static SpecieTogetic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogetic();
                }
                return _instance;
            }
        }

		public SpecieTogetic() : base(
			"Togetic",
			55, // HPs
			40, 85, // Attack & Defense
			80, 105, // Special Attack & Defense
			40			
		) {}
	}


	//Togetic Pokemon Class
	public class Togetic : Pokemon
	{

		public Togetic(string nickname, int level)
		: base(
				176,
				SpecieTogetic.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togetic(int level)
		: base(
				176,
				SpecieTogetic.Instance, // Pokemon Specie
				"Togetic", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togetic() : base(
			176,
			SpecieTogetic.Instance, // Pokemon Specie
			Fairy.Instance, Flying.Instance			
		) {}
	}
}