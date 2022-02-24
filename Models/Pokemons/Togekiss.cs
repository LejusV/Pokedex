using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Togekiss Specie to store common natural stats of every {'abilities': ['hustle', 'serene-grace', 'super-luck'], 'base_experience': 245, 'height': 15, 'id': 468, 'moves': ['fly', 'headbutt', 'flamethrower', 'hyper-beam', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'fire-blast', 'swift', 'dream-eater', 'sky-attack', 'flash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'endure', 'rollout', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'extreme-speed', 'ancient-power', 'shadow-ball', 'rock-smash', 'heat-wave', 'facade', 'focus-punch', 'trick', 'magic-coat', 'brick-break', 'endeavor', 'secret-power', 'hyper-voice', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'roost', 'natural-gift', 'pluck', 'tailwind', 'fling', 'last-resort', 'aura-sphere', 'air-slash', 'drain-punch', 'giga-impact', 'zen-headbutt', 'defog', 'captivate', 'grass-knot', 'ominous-wind', 'psyshock', 'telekinesis', 'after-you', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'work-up', 'confide', 'dazzling-gleam'], 'name': 'togekiss', 'stats': {'hp': 85, 'attack': 50, 'defense': 95, 'special-attack': 120, 'special-defense': 115, 'speed': 80}, 'types': ['fairy', 'flying'], 'weight': 380, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 1, 'capture_rate': 30, 'color': 'white', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['flying', 'fairy'], 'names': {'ja-Hrkt': 'トゲキッス', 'roomaji': 'Togekiss', 'ko': '토게키스', 'zh-Hant': '波克基斯', 'fr': 'Togekiss', 'de': 'Togekiss', 'es': 'Togekiss', 'it': 'Togekiss', 'en': 'Togekiss', 'ja': 'トゲキッス', 'zh-Hans': '波克基斯'}, 'genera': {'ja-Hrkt': 'しゅくふくポケモン', 'ko': '축복포켓몬', 'zh-Hant': '祝福寶可夢', 'fr': 'Pokémon Célébration', 'de': 'Jubilierer', 'es': 'Pokémon Festejo', 'it': 'Pokémon Festa', 'en': 'Jubilee Pokémon', 'ja': 'しゅくふくポケモン', 'zh-Hans': '祝福宝可梦'}}
	public class SpecieTogekiss : PokemonSpecie
	{
#nullable enable
		private static SpecieTogekiss? _instance = null;
#nullable restore
        public static SpecieTogekiss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTogekiss();
                }
                return _instance;
            }
        }

		public SpecieTogekiss() : base(
			"Togekiss",
			85, // HPs
			50, 95, // Attack & Defense
			120, 115, // Special Attack & Defense
			80			
		) {}
	}


	//Togekiss Pokemon Class
	public class Togekiss : Pokemon
	{

		public Togekiss(string nickname, int level)
		: base(
				468,
				SpecieTogekiss.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togekiss(int level)
		: base(
				468,
				SpecieTogekiss.Instance, // Pokemon Specie
				"Togekiss", level,
				Fairy.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Togekiss() : base(
			468,
			SpecieTogekiss.Instance, // Pokemon Specie
			Fairy.Instance, Flying.Instance			
		) {}
	}
}