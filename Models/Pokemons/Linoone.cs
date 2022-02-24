using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Linoone Specie to store common natural stats of every {'abilities': ['pickup', 'gluttony', 'quick-feet'], 'base_experience': 147, 'height': 5, 'id': 264, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'growl', 'roar', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'swift', 'fury-swipes', 'rest', 'super-fang', 'slash', 'substitute', 'thief', 'snore', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'helping-hand', 'trick', 'secret-power', 'mud-sport', 'hyper-voice', 'odor-sleuth', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'last-resort', 'seed-bomb', 'switcheroo', 'giga-impact', 'shadow-claw', 'gunk-shot', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'round', 'echoed-voice', 'retaliate', 'bestow', 'work-up', 'rototiller', 'play-rough', 'confide'], 'name': 'linoone', 'stats': {'hp': 78, 'attack': 70, 'defense': 61, 'special-attack': 50, 'special-defense': 61, 'speed': 100}, 'types': ['normal'], 'weight': 325, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'white', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マッスグマ', 'roomaji': 'Massuguma', 'ko': '직구리', 'zh-Hant': '直衝熊', 'fr': 'Linéon', 'de': 'Geradaks', 'es': 'Linoone', 'it': 'Linoone', 'en': 'Linoone', 'ja': 'マッスグマ', 'zh-Hans': '直冲熊'}, 'genera': {'ja-Hrkt': 'とっしんポケモン', 'ko': '돌진포켓몬', 'zh-Hant': '猛衝寶可夢', 'fr': 'Pokémon Fonceur', 'de': 'Sprinter', 'es': 'Pokémon Lanzado', 'it': 'Pokémon Sfrecciante', 'en': 'Rushing Pokémon', 'ja': 'とっしんポケモン', 'zh-Hans': '猛冲宝可梦'}}
	public class SpecieLinoone : PokemonSpecie
	{
#nullable enable
		private static SpecieLinoone? _instance = null;
#nullable restore
        public static SpecieLinoone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLinoone();
                }
                return _instance;
            }
        }

		public SpecieLinoone() : base(
			"Linoone",
			78, // HPs
			70, 61, // Attack & Defense
			50, 61, // Special Attack & Defense
			100			
		) {}
	}


	//Linoone Pokemon Class
	public class Linoone : Pokemon
	{

		public Linoone(string nickname, int level)
		: base(
				264,
				SpecieLinoone.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Linoone(int level)
		: base(
				264,
				SpecieLinoone.Instance, // Pokemon Specie
				"Linoone", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Linoone() : base(
			264,
			SpecieLinoone.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}