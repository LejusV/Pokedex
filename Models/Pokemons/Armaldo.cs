using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Armaldo Specie to store common natural stats of every {'abilities': ['battle-armor', 'swift-swim'], 'base_experience': 173, 'height': 15, 'id': 348, 'moves': ['scratch', 'swords-dance', 'cut', 'headbutt', 'body-slam', 'double-edge', 'water-gun', 'hyper-beam', 'low-kick', 'seismic-toss', 'strength', 'string-shot', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'metal-claw', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'mud-sport', 'crush-claw', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'rock-polish', 'aqua-tail', 'x-scissor', 'earth-power', 'giga-impact', 'flash-cannon', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'hone-claws', 'smack-down', 'round', 'struggle-bug', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'armaldo', 'stats': {'hp': 75, 'attack': 125, 'defense': 100, 'special-attack': 70, 'special-defense': 80, 'speed': 45}, 'types': ['rock', 'bug'], 'weight': 682, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'アーマルド', 'roomaji': 'Armaldo', 'ko': '아말도', 'zh-Hant': '太古盔甲', 'fr': 'Armaldo', 'de': 'Armaldo', 'es': 'Armaldo', 'it': 'Armaldo', 'en': 'Armaldo', 'ja': 'アーマルド', 'zh-Hans': '太古盔甲'}, 'genera': {'ja-Hrkt': 'かっちゅうポケモン', 'ko': '갑주포켓몬', 'zh-Hant': '甲胄寶可夢', 'fr': 'Pokémon Blindage', 'de': 'Schild', 'es': 'Pokémon Armadura', 'it': 'Pokémon Piastre', 'en': 'Plate Pokémon', 'ja': 'かっちゅうポケモン', 'zh-Hans': '甲胄宝可梦'}}
	public class SpecieArmaldo : PokemonSpecie
	{
#nullable enable
		private static SpecieArmaldo? _instance = null;
#nullable restore
        public static SpecieArmaldo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArmaldo();
                }
                return _instance;
            }
        }

		public SpecieArmaldo() : base(
			"Armaldo",
			75, // HPs
			125, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
			45			
		) {}
	}


	//Armaldo Pokemon Class
	public class Armaldo : Pokemon
	{

		public Armaldo(string nickname, int level)
		: base(
				348,
				SpecieArmaldo.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Armaldo() : base(
			348,
			SpecieArmaldo.Instance, // Pokemon Specie
			Rock.Instance, Bug.Instance			
		) {}
	}
}