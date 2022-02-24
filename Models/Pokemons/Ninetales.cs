using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ninetales Specie to store common natural stats of every {'abilities': ['flash-fire', 'drought'], 'base_experience': 177, 'height': 11, 'id': 38, 'moves': ['headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'solar-beam', 'fire-spin', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'confuse-ray', 'reflect', 'bide', 'fire-blast', 'swift', 'skull-bash', 'dream-eater', 'rest', 'substitute', 'snore', 'curse', 'spite', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'iron-tail', 'hidden-power', 'sunny-day', 'psych-up', 'heat-wave', 'will-o-wisp', 'facade', 'role-play', 'imprison', 'secret-power', 'overheat', 'covet', 'calm-mind', 'natural-gift', 'payback', 'dark-pulse', 'energy-ball', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'captivate', 'ominous-wind', 'psyshock', 'flame-charge', 'foul-play', 'round', 'incinerate', 'confide'], 'name': 'ninetales', 'stats': {'hp': 73, 'attack': 76, 'defense': 75, 'special-attack': 81, 'special-defense': 100, 'speed': 100}, 'types': ['fire'], 'weight': 199, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 75, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'キュウコン', 'roomaji': 'Kyukon', 'ko': '나인테일', 'zh-Hant': '九尾', 'fr': 'Feunard', 'de': 'Vulnona', 'es': 'Ninetales', 'it': 'Ninetales', 'en': 'Ninetales', 'ja': 'キュウコン', 'zh-Hans': '九尾'}, 'genera': {'ja-Hrkt': 'きつねポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'きつねポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieNinetales : PokemonSpecie
	{
#nullable enable
		private static SpecieNinetales? _instance = null;
#nullable restore
        public static SpecieNinetales Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNinetales();
                }
                return _instance;
            }
        }

		public SpecieNinetales() : base(
			"Ninetales",
			73, // HPs
			76, 75, // Attack & Defense
			81, 100, // Special Attack & Defense
			100			
		) {}
	}


	//Ninetales Pokemon Class
	public class Ninetales : Pokemon
	{

		public Ninetales(string nickname, int level)
		: base(
				38,
				SpecieNinetales.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ninetales() : base(
			38,
			SpecieNinetales.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}