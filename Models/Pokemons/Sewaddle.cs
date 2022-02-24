using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sewaddle Specie to store common natural stats of every {'abilities': ['swarm', 'chlorophyll', 'overcoat'], 'base_experience': 62, 'height': 3, 'id': 540, 'moves': ['razor-wind', 'cut', 'tackle', 'razor-leaf', 'solar-beam', 'string-shot', 'toxic', 'agility', 'screech', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'mind-reader', 'snore', 'flail', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'magic-coat', 'secret-power', 'camouflage', 'silver-wind', 'signal-beam', 'iron-defense', 'calm-mind', 'payback', 'me-first', 'worry-seed', 'seed-bomb', 'air-slash', 'bug-buzz', 'energy-ball', 'grass-knot', 'bug-bite', 'round', 'struggle-bug', 'electroweb', 'sticky-web', 'grassy-terrain', 'confide'], 'name': 'sewaddle', 'stats': {'hp': 45, 'attack': 53, 'defense': 70, 'special-attack': 40, 'special-defense': 60, 'speed': 42}, 'types': ['bug', 'grass'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'yellow', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'クルミル', 'ko': '두르보', 'zh-Hant': '蟲寶包', 'fr': 'Larveyette', 'de': 'Strawickl', 'es': 'Sewaddle', 'it': 'Sewaddle', 'en': 'Sewaddle', 'ja': 'クルミル', 'zh-Hans': '虫宝包'}, 'genera': {'ja-Hrkt': 'さいほうポケモン', 'ko': '재봉포켓몬', 'zh-Hant': '裁縫寶可夢', 'fr': 'Pokémon Couture', 'de': 'Schneider', 'es': 'Pokémon Sastre', 'it': 'Pokémon Grancucito', 'en': 'Sewing Pokémon', 'ja': 'さいほうポケモン', 'zh-Hans': '裁缝宝可梦'}}
	public class SpecieSewaddle : PokemonSpecie
	{
#nullable enable
		private static SpecieSewaddle? _instance = null;
#nullable restore
        public static SpecieSewaddle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSewaddle();
                }
                return _instance;
            }
        }

		public SpecieSewaddle() : base(
			"Sewaddle",
			45, // HPs
			53, 70, // Attack & Defense
			40, 60, // Special Attack & Defense
			42			
		) {}
	}


	//Sewaddle Pokemon Class
	public class Sewaddle : Pokemon
	{

		public Sewaddle(string nickname, int level)
		: base(
				540,
				SpecieSewaddle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sewaddle() : base(
			540,
			SpecieSewaddle.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}