using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wobbuffet Specie to store common natural stats of every {'abilities': ['shadow-tag', 'telepathy'], 'base_experience': 142, 'height': 13, 'id': 202, 'moves': ['counter', 'destiny-bond', 'safeguard', 'mirror-coat'], 'name': 'wobbuffet', 'stats': {'hp': 190, 'attack': 33, 'defense': 58, 'special-attack': 33, 'special-defense': 58, 'speed': 33}, 'types': ['psychic'], 'weight': 285, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'blob', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ソーナンス', 'roomaji': 'Sonans', 'ko': '마자용', 'zh-Hant': '果然翁', 'fr': 'Qulbutoké', 'de': 'Woingenau', 'es': 'Wobbuffet', 'it': 'Wobbuffet', 'en': 'Wobbuffet', 'ja': 'ソーナンス', 'zh-Hans': '果然翁'}, 'genera': {'ja-Hrkt': 'がまんポケモン', 'ko': '참기포켓몬', 'zh-Hant': '忍耐寶可夢', 'fr': 'Pokémon Patient', 'de': 'Geduld', 'es': 'Pokémon Paciente', 'it': 'Pokémon Pazienza', 'en': 'Patient Pokémon', 'ja': 'がまんポケモン', 'zh-Hans': '忍耐宝可梦'}}
	public class SpecieWobbuffet : PokemonSpecie
	{
#nullable enable
		private static SpecieWobbuffet? _instance = null;
#nullable restore
        public static SpecieWobbuffet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWobbuffet();
                }
                return _instance;
            }
        }

		public SpecieWobbuffet() : base(
			"Wobbuffet",
			190, // HPs
			33, 58, // Attack & Defense
			33, 58, // Special Attack & Defense
			33			
		) {}
	}


	//Wobbuffet Pokemon Class
	public class Wobbuffet : Pokemon
	{

		public Wobbuffet(string nickname, int level)
		: base(
				202,
				SpecieWobbuffet.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wobbuffet(int level)
		: base(
				202,
				SpecieWobbuffet.Instance, // Pokemon Specie
				"Wobbuffet", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wobbuffet() : base(
			202,
			SpecieWobbuffet.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}