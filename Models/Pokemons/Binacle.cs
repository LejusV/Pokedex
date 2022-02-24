using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Binacle Specie to store common natural stats of every {'abilities': ['tough-claws', 'sniper', 'pickpocket'], 'base_experience': 61, 'height': 5, 'id': 688, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'clamp', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'cross-chop', 'rain-dance', 'ancient-power', 'rock-smash', 'torment', 'facade', 'nature-power', 'taunt', 'helping-hand', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'tickle', 'aerial-ace', 'iron-defense', 'water-sport', 'water-pulse', 'payback', 'embargo', 'fling', 'rock-polish', 'poison-jab', 'night-slash', 'x-scissor', 'switcheroo', 'shadow-claw', 'stone-edge', 'stealth-rock', 'grass-knot', 'hone-claws', 'smack-down', 'sludge-wave', 'round', 'scald', 'shell-smash', 'bulldoze', 'dual-chop', 'razor-shell', 'confide', 'infestation', 'power-up-punch'], 'name': 'binacle', 'stats': {'hp': 42, 'attack': 52, 'defense': 67, 'special-attack': 39, 'special-defense': 56, 'speed': 50}, 'types': ['rock', 'water'], 'weight': 310, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'heads', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'カメテテ', 'ko': '거북손손', 'zh-Hant': '龜腳腳', 'fr': 'Opermine', 'de': 'Bithora', 'es': 'Binacle', 'it': 'Binacle', 'en': 'Binacle', 'ja': 'カメテテ', 'zh-Hans': '龟脚脚'}, 'genera': {'ja-Hrkt': 'ふたてポケモン', 'ko': '두손포켓몬', 'zh-Hant': '雙手寶可夢', 'fr': 'Pokémon Bimane', 'de': 'Krallenduo', 'es': 'Pokémon Dos Manos', 'it': 'Pokémon Bimano', 'en': 'Two-Handed Pokémon', 'ja': 'ふたてポケモン', 'zh-Hans': '双手宝可梦'}}
	public class SpecieBinacle : PokemonSpecie
	{
#nullable enable
		private static SpecieBinacle? _instance = null;
#nullable restore
        public static SpecieBinacle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBinacle();
                }
                return _instance;
            }
        }

		public SpecieBinacle() : base(
			"Binacle",
			42, // HPs
			52, 67, // Attack & Defense
			39, 56, // Special Attack & Defense
			50			
		) {}
	}


	//Binacle Pokemon Class
	public class Binacle : Pokemon
	{

		public Binacle(string nickname, int level)
		: base(
				688,
				SpecieBinacle.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Binacle(int level)
		: base(
				688,
				SpecieBinacle.Instance, // Pokemon Specie
				"Binacle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Binacle() : base(
			688,
			SpecieBinacle.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}