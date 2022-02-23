using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snover Specie to store common natural stats of every {'abilities': ['snow-warning', 'soundproof'], 'base_experience': 67, 'height': 10, 'id': 459, 'moves': ['ice-punch', 'swords-dance', 'stomp', 'headbutt', 'double-edge', 'leer', 'mist', 'ice-beam', 'blizzard', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'light-screen', 'skull-bash', 'flash', 'rest', 'substitute', 'snore', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'synthesis', 'hidden-power', 'rain-dance', 'shadow-ball', 'hail', 'facade', 'role-play', 'ingrain', 'secret-power', 'grass-whistle', 'sheer-cold', 'bullet-seed', 'magical-leaf', 'water-pulse', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'avalanche', 'ice-shard', 'captivate', 'grass-knot', 'wood-hammer', 'round', 'frost-breath', 'confide'], 'name': 'snover', 'stats': {'hp': 60, 'attack': 62, 'defense': 50, 'special-attack': 62, 'special-defense': 60, 'speed': 40}, 'types': ['grass', 'ice'], 'weight': 505, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['monster', 'plant'], 'names': {'ja-Hrkt': 'ユキカブリ', 'roomaji': 'Yukikaburi', 'ko': '눈쓰개', 'zh-Hant': '雪笠怪', 'fr': 'Blizzi', 'de': 'Shnebedeck', 'es': 'Snover', 'it': 'Snover', 'en': 'Snover', 'ja': 'ユキカブリ', 'zh-Hans': '雪笠怪'}, 'genera': {'ja-Hrkt': 'じゅひょうポケモン', 'ko': '얼음나무포켓몬', 'zh-Hant': '樹冰寶可夢', 'fr': 'Pokémon Arbregelé', 'de': 'Frostbaum', 'es': 'Pokémon Árbol Nieve', 'it': 'Pokémon Albergelo', 'en': 'Frost Tree Pokémon', 'ja': 'じゅひょうポケモン', 'zh-Hans': '树冰宝可梦'}}
	public class SpecieSnover : PokemonSpecie
	{
#nullable enable
		private static SpecieSnover? _instance = null;
#nullable restore
        public static SpecieSnover Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnover();
                }
                return _instance;
            }
        }

		public SpecieSnover() : base(
			"Snover",
			60, // HPs
			62, 50, // Attack & Defense
			62, 60, // Special Attack & Defense
			40			
		) {}
	}


	//Snover Pokemon Class
	public class Snover : Pokemon
	{

		public Snover(string nickname, int level) : base(
			459,
			SpecieSnover.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Ice.Instance			
		) {}

		public Snover() : base(
			459,
			SpecieSnover.Instance, // Pokemon Specie
			Grass.Instance, Ice.Instance			
		) {}
	}
}