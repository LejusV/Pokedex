using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tyrunt Specie to store common natural stats of every {'abilities': ['strong-jaw', 'sturdy'], 'base_experience': 72, 'height': 8, 'id': 696, 'moves': ['stomp', 'horn-drill', 'tackle', 'thrash', 'tail-whip', 'bite', 'roar', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'outrage', 'sandstorm', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'brick-break', 'secret-power', 'hyper-voice', 'poison-fang', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'dragon-dance', 'rock-polish', 'dark-pulse', 'dragon-pulse', 'earth-power', 'thunder-fang', 'ice-fang', 'fire-fang', 'zen-headbutt', 'draco-meteor', 'iron-head', 'stone-edge', 'stealth-rock', 'hone-claws', 'round', 'bulldoze', 'dragon-tail', 'confide'], 'name': 'tyrunt', 'stats': {'hp': 58, 'attack': 89, 'defense': 77, 'special-attack': 45, 'special-defense': 45, 'speed': 48}, 'types': ['rock', 'dragon'], 'weight': 260, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'チゴラス', 'ko': '티고라스', 'zh-Hant': '寶寶暴龍', 'fr': 'Ptyranidur', 'de': 'Balgoras', 'es': 'Tyrunt', 'it': 'Tyrunt', 'en': 'Tyrunt', 'ja': 'チゴラス', 'zh-Hans': '宝宝暴龙'}, 'genera': {'ja-Hrkt': 'ようくんポケモン', 'ko': '유군포켓몬', 'zh-Hant': '幼君寶可夢', 'fr': 'Pokémon Prince', 'de': 'Kronprinz', 'es': 'Pokémon Heredero', 'it': 'Pokémon Principino', 'en': 'Royal Heir Pokémon', 'ja': 'ようくんポケモン', 'zh-Hans': '幼君宝可梦'}}
	public class SpecieTyrunt : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrunt? _instance = null;
#nullable restore
        public static SpecieTyrunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrunt();
                }
                return _instance;
            }
        }

		public SpecieTyrunt() : base(
			"Tyrunt",
			58, // HPs
			89, 77, // Attack & Defense
			45, 45, // Special Attack & Defense
			48			
		) {}
	}


	//Tyrunt Pokemon Class
	public class Tyrunt : Pokemon
	{

		public Tyrunt(string nickname, int level)
		: base(
				696,
				SpecieTyrunt.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tyrunt() : base(
			696,
			SpecieTyrunt.Instance, // Pokemon Specie
			Rock.Instance, Dragon.Instance			
		) {}
	}
}