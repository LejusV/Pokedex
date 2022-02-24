using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Latias Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 270, 'height': 14, 'id': 380, 'moves': ['cut', 'fly', 'body-slam', 'double-edge', 'roar', 'surf', 'ice-beam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'psychic', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'waterfall', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'charm', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'whirlpool', 'facade', 'helping-hand', 'trick', 'role-play', 'wish', 'magic-coat', 'refresh', 'secret-power', 'dive', 'mist-ball', 'aerial-ace', 'dragon-claw', 'covet', 'water-sport', 'calm-mind', 'shock-wave', 'water-pulse', 'roost', 'healing-wish', 'natural-gift', 'tailwind', 'psycho-shift', 'last-resort', 'sucker-punch', 'dragon-pulse', 'energy-ball', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'defog', 'draco-meteor', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'guard-split', 'psyshock', 'telekinesis', 'magic-room', 'round', 'stored-power', 'heal-pulse', 'reflect-type', 'retaliate', 'bulldoze', 'confide'], 'name': 'latias', 'stats': {'hp': 80, 'attack': 80, 'defense': 90, 'special-attack': 110, 'special-defense': 130, 'speed': 110}, 'types': ['dragon', 'psychic'], 'weight': 400, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 8, 'capture_rate': 3, 'color': 'red', 'shape': 'wings', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ラティアス', 'roomaji': 'Latias', 'ko': '라티아스', 'zh-Hant': '拉帝亞斯', 'fr': 'Latias', 'de': 'Latias', 'es': 'Latias', 'it': 'Latias', 'en': 'Latias', 'ja': 'ラティアス', 'zh-Hans': '拉帝亚斯'}, 'genera': {'ja-Hrkt': 'むげんポケモン', 'ko': '무한포켓몬', 'zh-Hant': '無限寶可夢', 'fr': 'Pokémon Éon', 'de': 'Äon', 'es': 'Pokémon Eón', 'it': 'Pokémon Eone', 'en': 'Eon Pokémon', 'ja': 'むげんポケモン', 'zh-Hans': '无限宝可梦'}}
	public class SpecieLatias : PokemonSpecie
	{
#nullable enable
		private static SpecieLatias? _instance = null;
#nullable restore
        public static SpecieLatias Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLatias();
                }
                return _instance;
            }
        }

		public SpecieLatias() : base(
			"Latias",
			80, // HPs
			80, 90, // Attack & Defense
			110, 130, // Special Attack & Defense
			110			
		) {}
	}


	//Latias Pokemon Class
	public class Latias : Pokemon
	{

		public Latias(string nickname, int level)
		: base(
				380,
				SpecieLatias.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Latias() : base(
			380,
			SpecieLatias.Instance, // Pokemon Specie
			Dragon.Instance, Psychic.Instance			
		) {}
	}
}