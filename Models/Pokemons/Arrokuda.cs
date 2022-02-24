using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arrokuda Specie to store common natural stats of every {'abilities': ['swift-swim', 'propeller-tail'], 'base_experience': 56, 'height': 5, 'id': 846, 'moves': [], 'name': 'arrokuda', 'stats': {'hp': 41, 'attack': 63, 'defense': 40, 'special-attack': 40, 'special-defense': 30, 'speed': 66}, 'types': ['water'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'fish', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'サシカマス', 'ko': '찌로꼬치', 'zh-Hant': '刺梭魚', 'fr': 'Embrochet', 'de': 'Pikuda', 'es': 'Arrokuda', 'it': 'Arrokuda', 'en': 'Arrokuda', 'ja': 'サシカマス', 'zh-Hans': '刺梭鱼'}, 'genera': {'ja-Hrkt': 'とつげきポケモン', 'ko': '돌격포켓몬', 'zh-Hant': '突擊寶可夢', 'fr': 'Pokémon Fonceur', 'de': 'Rempler', 'es': 'Pokémon Arremetida', 'it': 'Pokémon Carica', 'en': 'Rush Pokémon', 'ja': 'とつげきポケモン', 'zh-Hans': '突击宝可梦'}}
	public class SpecieArrokuda : PokemonSpecie
	{
#nullable enable
		private static SpecieArrokuda? _instance = null;
#nullable restore
        public static SpecieArrokuda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArrokuda();
                }
                return _instance;
            }
        }

		public SpecieArrokuda() : base(
			"Arrokuda",
			41, // HPs
			63, 40, // Attack & Defense
			40, 30, // Special Attack & Defense
			66			
		) {}
	}


	//Arrokuda Pokemon Class
	public class Arrokuda : Pokemon
	{

		public Arrokuda(string nickname, int level)
		: base(
				846,
				SpecieArrokuda.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arrokuda(int level)
		: base(
				846,
				SpecieArrokuda.Instance, // Pokemon Specie
				"Arrokuda", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arrokuda() : base(
			846,
			SpecieArrokuda.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}