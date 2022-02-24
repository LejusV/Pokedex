using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jangmo-O Specie to store common natural stats of every {'abilities': ['bulletproof', 'soundproof', 'overcoat'], 'base_experience': 60, 'height': 6, 'id': 782, 'moves': ['swords-dance', 'headbutt', 'tackle', 'leer', 'roar', 'counter', 'earthquake', 'toxic', 'screech', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'reversal', 'protect', 'scary-face', 'outrage', 'sandstorm', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'facade', 'taunt', 'brick-break', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bulk-up', 'dragon-dance', 'payback', 'x-scissor', 'focus-blast', 'shadow-claw', 'draco-meteor', 'round', 'echoed-voice', 'bulldoze', 'dragon-tail', 'work-up', 'noble-roar', 'confide'], 'name': 'jangmo-o', 'stats': {'hp': 45, 'attack': 55, 'defense': 65, 'special-attack': 45, 'special-defense': 45, 'speed': 45}, 'types': ['dragon'], 'weight': 297, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ジャラコ', 'ko': '짜랑꼬', 'zh-Hant': '心鱗寶', 'fr': 'Bébécaille', 'de': 'Miniras', 'es': 'Jangmo-o', 'it': 'Jangmo-o', 'en': 'Jangmo-o', 'ja': 'ジャラコ', 'zh-Hans': '心鳞宝'}, 'genera': {'ja-Hrkt': 'うろこポケモン', 'ko': '비늘포켓몬', 'zh-Hant': '鱗片寶可夢', 'fr': 'Pokémon Écailles', 'de': 'Schuppentier', 'es': 'Pokémon Escamas', 'it': 'Pokémon Squama', 'en': 'Scaly Pokémon', 'ja': 'うろこポケモン', 'zh-Hans': '鳞片宝可梦'}}
	public class SpecieJangmoO : PokemonSpecie
	{
#nullable enable
		private static SpecieJangmoO? _instance = null;
#nullable restore
        public static SpecieJangmoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJangmoO();
                }
                return _instance;
            }
        }

		public SpecieJangmoO() : base(
			"Jangmo-O",
			45, // HPs
			55, 65, // Attack & Defense
			45, 45, // Special Attack & Defense
			45			
		) {}
	}


	//Jangmo-O Pokemon Class
	public class JangmoO : Pokemon
	{

		public JangmoO(string nickname, int level)
		: base(
				782,
				SpecieJangmoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public JangmoO() : base(
			782,
			SpecieJangmoO.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}