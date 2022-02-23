using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pheromosa Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 18, 'id': 795, 'moves': ['stomp', 'double-kick', 'jump-kick', 'leer', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'toxic', 'agility', 'double-team', 'swift', 'high-jump-kick', 'rest', 'substitute', 'triple-kick', 'protect', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'torment', 'facade', 'taunt', 'brick-break', 'silver-wind', 'bounce', 'roost', 'feint', 'u-turn', 'fling', 'me-first', 'poison-jab', 'bug-buzz', 'focus-blast', 'giga-impact', 'quiver-dance', 'low-sweep', 'round', 'echoed-voice', 'quick-guard', 'confide', 'lunge', 'speed-swap'], 'name': 'pheromosa', 'stats': {'hp': 71, 'attack': 137, 'defense': 37, 'special-attack': 137, 'special-defense': 37, 'speed': 151}, 'types': ['bug', 'fighting'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'フェローチェ', 'ko': '페로코체', 'zh-Hant': '費洛美螂', 'fr': 'Cancrelove', 'de': 'Schabelle', 'es': 'Pheromosa', 'it': 'Pheromosa', 'en': 'Pheromosa', 'ja': 'フェローチェ', 'zh-Hans': '费洛美螂'}, 'genera': {'ja-Hrkt': 'えんびポケモン', 'ko': '염미포켓몬', 'zh-Hant': '美艷寶可夢', 'fr': 'Pokémon Gracile', 'de': 'Eleganz', 'es': 'Pokémon Elegancia', 'it': 'Pokémon Leggiadria', 'en': 'Lissome Pokémon', 'ja': 'えんびポケモン', 'zh-Hans': '美艳宝可梦'}}
	public class SpeciePheromosa : PokemonSpecie
	{
#nullable enable
		private static SpeciePheromosa? _instance = null;
#nullable restore
        public static SpeciePheromosa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePheromosa();
                }
                return _instance;
            }
        }

		public SpeciePheromosa() : base(
			"Pheromosa",
			71, // HPs
			137, 37, // Attack & Defense
			137, 37, // Special Attack & Defense
			151			
		) {}
	}


	//Pheromosa Pokemon Class
	public class Pheromosa : Pokemon
	{

		public Pheromosa(string nickname, int level) : base(
			795,
			SpeciePheromosa.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Fighting.Instance			
		) {}

		public Pheromosa() : base(
			795,
			SpeciePheromosa.Instance, // Pokemon Specie
			Bug.Instance, Fighting.Instance			
		) {}
	}
}