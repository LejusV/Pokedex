using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Abomasnow Specie to store common natural stats of every {'abilities': ['snow-warning', 'soundproof'], 'base_experience': 173, 'height': 22, 'id': 460, 'moves': ['ice-punch', 'swords-dance', 'headbutt', 'leer', 'mist', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'razor-leaf', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'light-screen', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'outrage', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'rain-dance', 'shadow-ball', 'rock-smash', 'hail', 'facade', 'focus-punch', 'role-play', 'ingrain', 'brick-break', 'secret-power', 'rock-tomb', 'grass-whistle', 'sheer-cold', 'bullet-seed', 'block', 'water-pulse', 'natural-gift', 'fling', 'worry-seed', 'seed-bomb', 'focus-blast', 'energy-ball', 'giga-impact', 'avalanche', 'ice-shard', 'rock-climb', 'captivate', 'grass-knot', 'wood-hammer', 'round', 'bulldoze', 'frost-breath', 'confide'], 'name': 'abomasnow', 'stats': {'hp': 90, 'attack': 92, 'defense': 75, 'special-attack': 92, 'special-defense': 85, 'speed': 60}, 'types': ['grass', 'ice'], 'weight': 1355, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ユキノオー', 'roomaji': 'Yukinooh', 'ko': '눈설왕', 'zh-Hant': '暴雪王', 'fr': 'Blizzaroi', 'de': 'Rexblisar', 'es': 'Abomasnow', 'it': 'Abomasnow', 'en': 'Abomasnow', 'ja': 'ユキノオー', 'zh-Hans': '暴雪王'}, 'genera': {'ja-Hrkt': 'じゅひょうポケモン', 'ko': '얼음나무포켓몬', 'zh-Hant': '樹冰寶可夢', 'fr': 'Pokémon Arbregelé', 'de': 'Frostbaum', 'es': 'Pokémon Árbol Nieve', 'it': 'Pokémon Albergelo', 'en': 'Frost Tree Pokémon', 'ja': 'じゅひょうポケモン', 'zh-Hans': '树冰宝可梦'}}
	public class SpecieAbomasnow : PokemonSpecie
	{
#nullable enable
		private static SpecieAbomasnow? _instance = null;
#nullable restore
        public static SpecieAbomasnow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbomasnow();
                }
                return _instance;
            }
        }

		public SpecieAbomasnow() : base(
			"Abomasnow",
			90, // HPs
			92, 75, // Attack & Defense
			92, 85, // Special Attack & Defense
			60			
		) {}
	}


	//Abomasnow Pokemon Class
	public class Abomasnow : Pokemon
	{

		public Abomasnow(string nickname, int level)
		: base(
				460,
				SpecieAbomasnow.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Abomasnow() : base(
			460,
			SpecieAbomasnow.Instance, // Pokemon Specie
			Grass.Instance, Ice.Instance			
		) {}
	}
}