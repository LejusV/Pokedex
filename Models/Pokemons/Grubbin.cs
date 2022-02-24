using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grubbin Specie to store common natural stats of every {'abilities': ['swarm'], 'base_experience': 60, 'height': 4, 'id': 736, 'moves': ['vice-grip', 'bite', 'string-shot', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'double-team', 'harden', 'light-screen', 'rest', 'substitute', 'protect', 'mud-slap', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'mud-shot', 'poison-jab', 'x-scissor', 'bug-bite', 'charge-beam', 'round', 'acrobatics', 'volt-switch', 'electroweb', 'wild-charge', 'confide'], 'name': 'grubbin', 'stats': {'hp': 47, 'attack': 62, 'defense': 45, 'special-attack': 55, 'special-defense': 45, 'speed': 46}, 'types': ['bug'], 'weight': 44, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'アゴジムシ', 'ko': '턱지충이', 'zh-Hant': '強顎雞母蟲', 'fr': 'Larvibule', 'de': 'Mabula', 'es': 'Grubbin', 'it': 'Grubbin', 'en': 'Grubbin', 'ja': 'アゴジムシ', 'zh-Hans': '强颚鸡母虫'}, 'genera': {'ja-Hrkt': 'ようちゅうポケモン', 'ko': '유충포켓몬', 'zh-Hant': '幼蟲寶可夢', 'fr': 'Pokémon Larve', 'de': 'Larve', 'es': 'Pokémon Pupa', 'it': 'Pokémon Coleolarva', 'en': 'Larva Pokémon', 'ja': 'ようちゅうポケモン', 'zh-Hans': '幼虫宝可梦'}}
	public class SpecieGrubbin : PokemonSpecie
	{
#nullable enable
		private static SpecieGrubbin? _instance = null;
#nullable restore
        public static SpecieGrubbin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrubbin();
                }
                return _instance;
            }
        }

		public SpecieGrubbin() : base(
			"Grubbin",
			47, // HPs
			62, 45, // Attack & Defense
			55, 45, // Special Attack & Defense
			46			
		) {}
	}


	//Grubbin Pokemon Class
	public class Grubbin : Pokemon
	{

		public Grubbin(string nickname, int level)
		: base(
				736,
				SpecieGrubbin.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grubbin(int level)
		: base(
				736,
				SpecieGrubbin.Instance, // Pokemon Specie
				"Grubbin", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grubbin() : base(
			736,
			SpecieGrubbin.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}