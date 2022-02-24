using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandile Specie to store common natural stats of every {'abilities': ['intimidate', 'moxie', 'anger-point'], 'base_experience': 58, 'height': 7, 'id': 551, 'moves': ['cut', 'sand-attack', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'counter', 'earthquake', 'dig', 'toxic', 'rage', 'double-team', 'focus-energy', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'sandstorm', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'crunch', 'beat-up', 'uproar', 'torment', 'facade', 'taunt', 'snatch', 'secret-power', 'rock-tomb', 'sand-tomb', 'payback', 'assurance', 'embargo', 'me-first', 'dark-pulse', 'aqua-tail', 'earth-power', 'thunder-fang', 'fire-fang', 'rock-climb', 'stone-edge', 'stealth-rock', 'hone-claws', 'foul-play', 'round', 'incinerate', 'retaliate', 'bulldoze', 'snarl', 'confide', 'power-trip'], 'name': 'sandile', 'stats': {'hp': 50, 'attack': 72, 'defense': 35, 'special-attack': 35, 'special-defense': 35, 'speed': 65}, 'types': ['ground', 'dark'], 'weight': 152, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 180, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'メグロコ', 'ko': '깜눈크', 'zh-Hant': '黑眼鱷', 'fr': 'Mascaïman', 'de': 'Ganovil', 'es': 'Sandile', 'it': 'Sandile', 'en': 'Sandile', 'ja': 'メグロコ', 'zh-Hans': '黑眼鳄'}, 'genera': {'ja-Hrkt': 'さばくワニポケモン', 'ko': '사막악어포켓몬', 'zh-Hant': '沙漠鱷魚寶可夢', 'fr': 'Pokémon Croco Sable', 'de': 'Wüstenkroko', 'es': 'Pokémon Desierdrilo', 'it': 'Pokémon Sabbiadrillo', 'en': 'Desert Croc Pokémon', 'ja': 'さばくワニポケモン', 'zh-Hans': '沙漠鳄鱼宝可梦'}}
	public class SpecieSandile : PokemonSpecie
	{
#nullable enable
		private static SpecieSandile? _instance = null;
#nullable restore
        public static SpecieSandile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandile();
                }
                return _instance;
            }
        }

		public SpecieSandile() : base(
			"Sandile",
			50, // HPs
			72, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
			65			
		) {}
	}


	//Sandile Pokemon Class
	public class Sandile : Pokemon
	{

		public Sandile(string nickname, int level)
		: base(
				551,
				SpecieSandile.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandile(int level)
		: base(
				551,
				SpecieSandile.Instance, // Pokemon Specie
				"Sandile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandile() : base(
			551,
			SpecieSandile.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
	}
}