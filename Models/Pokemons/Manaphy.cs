using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Manaphy Specie to store common natural stats of every {'abilities': ['hydration'], 'base_experience': 270, 'height': 3, 'id': 490, 'moves': ['supersonic', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'waterfall', 'swift', 'bubble', 'flash', 'acid-armor', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'charm', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'shadow-ball', 'whirlpool', 'uproar', 'hail', 'facade', 'helping-hand', 'knock-off', 'skill-swap', 'secret-power', 'dive', 'tail-glow', 'signal-beam', 'bounce', 'covet', 'water-sport', 'calm-mind', 'water-pulse', 'brine', 'natural-gift', 'u-turn', 'fling', 'last-resort', 'heart-swap', 'aqua-ring', 'energy-ball', 'giga-impact', 'grass-knot', 'round', 'scald', 'confide', 'dazzling-gleam'], 'name': 'manaphy', 'stats': {'hp': 100, 'attack': 100, 'defense': 100, 'special-attack': 100, 'special-defense': 100, 'speed': 100}, 'types': ['water'], 'weight': 14, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 10, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['water1', 'fairy'], 'names': {'ja-Hrkt': 'マナフィ', 'roomaji': 'Manaphy', 'ko': '마나피', 'zh-Hant': '瑪納霏', 'fr': 'Manaphy', 'de': 'Manaphy', 'es': 'Manaphy', 'it': 'Manaphy', 'en': 'Manaphy', 'ja': 'マナフィ', 'zh-Hans': '玛纳霏'}, 'genera': {'ja-Hrkt': 'かいゆうポケモン', 'ko': '회유포켓몬', 'zh-Hant': '洄游寶可夢', 'fr': 'Pokémon Voyagenmer', 'de': 'Seefahrer', 'es': 'Pokémon Náutico', 'it': 'Pokémon Oceandante', 'en': 'Seafaring Pokémon', 'ja': 'かいゆうポケモン', 'zh-Hans': '回游宝可梦'}}
	public class SpecieManaphy : PokemonSpecie
	{
#nullable enable
		private static SpecieManaphy? _instance = null;
#nullable restore
        public static SpecieManaphy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieManaphy();
                }
                return _instance;
            }
        }

		public SpecieManaphy() : base(
			"Manaphy",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Manaphy Pokemon Class
	public class Manaphy : Pokemon
	{

		public Manaphy(string nickname, int level)
		: base(
				490,
				SpecieManaphy.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Manaphy(int level)
		: base(
				490,
				SpecieManaphy.Instance, // Pokemon Specie
				"Manaphy", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Manaphy() : base(
			490,
			SpecieManaphy.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}