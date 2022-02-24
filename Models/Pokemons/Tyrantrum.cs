using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tyrantrum Specie to store common natural stats of every {'abilities': ['strong-jaw', 'rock-head'], 'base_experience': 182, 'height': 25, 'id': 697, 'moves': ['stomp', 'horn-drill', 'tackle', 'thrash', 'tail-whip', 'bite', 'roar', 'hyper-beam', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'outrage', 'sandstorm', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'brick-break', 'secret-power', 'hyper-voice', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'rock-polish', 'dark-pulse', 'dragon-pulse', 'earth-power', 'giga-impact', 'zen-headbutt', 'draco-meteor', 'iron-head', 'stone-edge', 'stealth-rock', 'head-smash', 'hone-claws', 'round', 'bulldoze', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'tyrantrum', 'stats': {'hp': 82, 'attack': 121, 'defense': 119, 'special-attack': 69, 'special-defense': 59, 'speed': 71}, 'types': ['rock', 'dragon'], 'weight': 2700, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ガチゴラス', 'ko': '견고라스', 'zh-Hant': '怪顎龍', 'fr': 'Rexillius', 'de': 'Monargoras', 'es': 'Tyrantrum', 'it': 'Tyrantrum', 'en': 'Tyrantrum', 'ja': 'ガチゴラス', 'zh-Hans': '怪颚龙'}, 'genera': {'ja-Hrkt': 'ぼうくんポケモン', 'ko': '폭군포켓몬', 'zh-Hant': '暴君寶可夢', 'fr': 'Pokémon Tyran', 'de': 'Tyrann', 'es': 'Pokémon Tirano', 'it': 'Pokémon Tiranno', 'en': 'Despot Pokémon', 'ja': 'ぼうくんポケモン', 'zh-Hans': '暴君宝可梦'}}
	public class SpecieTyrantrum : PokemonSpecie
	{
#nullable enable
		private static SpecieTyrantrum? _instance = null;
#nullable restore
        public static SpecieTyrantrum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyrantrum();
                }
                return _instance;
            }
        }

		public SpecieTyrantrum() : base(
			"Tyrantrum",
			82, // HPs
			121, 119, // Attack & Defense
			69, 59, // Special Attack & Defense
			71			
		) {}
	}


	//Tyrantrum Pokemon Class
	public class Tyrantrum : Pokemon
	{

		public Tyrantrum(string nickname, int level)
		: base(
				697,
				SpecieTyrantrum.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tyrantrum() : base(
			697,
			SpecieTyrantrum.Instance, // Pokemon Specie
			Rock.Instance, Dragon.Instance			
		) {}
	}
}