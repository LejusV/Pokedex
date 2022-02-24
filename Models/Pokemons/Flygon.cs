using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flygon Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 234, 'height': 20, 'id': 330, 'moves': ['fire-punch', 'thunder-punch', 'fly', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'bite', 'supersonic', 'sonic-boom', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'bide', 'fire-blast', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'feint-attack', 'mud-slap', 'outrage', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'heat-wave', 'facade', 'superpower', 'secret-power', 'air-cutter', 'rock-tomb', 'silver-wind', 'signal-beam', 'sand-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'dragon-pulse', 'dragon-rush', 'earth-power', 'giga-impact', 'defog', 'draco-meteor', 'stone-edge', 'captivate', 'bug-bite', 'ominous-wind', 'hone-claws', 'round', 'incinerate', 'struggle-bug', 'bulldoze', 'dragon-tail', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'flygon', 'stats': {'hp': 80, 'attack': 100, 'defense': 80, 'special-attack': 80, 'special-defense': 80, 'speed': 100}, 'types': ['ground', 'dragon'], 'weight': 820, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'wings', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'フライゴン', 'roomaji': 'Frygon', 'ko': '플라이곤', 'zh-Hant': '沙漠蜻蜓', 'fr': 'Libégon', 'de': 'Libelldra', 'es': 'Flygon', 'it': 'Flygon', 'en': 'Flygon', 'ja': 'フライゴン', 'zh-Hans': '沙漠蜻蜓'}, 'genera': {'ja-Hrkt': 'せいれいポケモン', 'ko': '정령포켓몬', 'zh-Hant': '神秘寶可夢', 'fr': 'Pokémon Mystique', 'de': 'Mystik', 'es': 'Pokémon Místico', 'it': 'Pokémon Magico', 'en': 'Mystic Pokémon', 'ja': 'せいれいポケモン', 'zh-Hans': '神秘宝可梦'}}
	public class SpecieFlygon : PokemonSpecie
	{
#nullable enable
		private static SpecieFlygon? _instance = null;
#nullable restore
        public static SpecieFlygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlygon();
                }
                return _instance;
            }
        }

		public SpecieFlygon() : base(
			"Flygon",
			80, // HPs
			100, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			100			
		) {}
	}


	//Flygon Pokemon Class
	public class Flygon : Pokemon
	{

		public Flygon(string nickname, int level)
		: base(
				330,
				SpecieFlygon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flygon(int level)
		: base(
				330,
				SpecieFlygon.Instance, // Pokemon Specie
				"Flygon", level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flygon() : base(
			330,
			SpecieFlygon.Instance, // Pokemon Specie
			Ground.Instance, Dragon.Instance			
		) {}
	}
}