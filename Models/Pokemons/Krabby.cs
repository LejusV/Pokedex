using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Krabby Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'shell-armor', 'sheer-force'], 'base_experience': 65, 'height': 4, 'id': 98, 'moves': ['vice-grip', 'guillotine', 'swords-dance', 'cut', 'slam', 'stomp', 'body-slam', 'take-down', 'double-edge', 'leer', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'strength', 'dig', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'harden', 'haze', 'bide', 'amnesia', 'bubble', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'icy-wind', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'tickle', 'iron-defense', 'mud-shot', 'water-pulse', 'brine', 'natural-gift', 'fling', 'x-scissor', 'captivate', 'hone-claws', 'round', 'chip-away', 'ally-switch', 'scald', 'confide'], 'name': 'krabby', 'stats': {'hp': 30, 'attack': 105, 'defense': 90, 'special-attack': 25, 'special-defense': 25, 'speed': 50}, 'types': ['water'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'red', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'クラブ', 'roomaji': 'Crab', 'ko': '크랩', 'zh-Hant': '大鉗蟹', 'fr': 'Krabby', 'de': 'Krabby', 'es': 'Krabby', 'it': 'Krabby', 'en': 'Krabby', 'ja': 'クラブ', 'zh-Hans': '大钳蟹'}, 'genera': {'ja-Hrkt': 'さわがにポケモン', 'ko': '게포켓몬', 'zh-Hant': '清水蟹寶可夢', 'fr': 'Pokémon Doux Crabe', 'de': 'Krabbe', 'es': 'Pokémon Cangrejo', 'it': 'Pokémon Granchio', 'en': 'River Crab Pokémon', 'ja': 'さわがにポケモン', 'zh-Hans': '清水蟹宝可梦'}}
	public class SpecieKrabby : PokemonSpecie
	{
#nullable enable
		private static SpecieKrabby? _instance = null;
#nullable restore
        public static SpecieKrabby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrabby();
                }
                return _instance;
            }
        }

		public SpecieKrabby() : base(
			"Krabby",
			30, // HPs
			105, 90, // Attack & Defense
			25, 25, // Special Attack & Defense
			50			
		) {}
	}


	//Krabby Pokemon Class
	public class Krabby : Pokemon
	{

		public Krabby(string nickname, int level) : base(
			98,
			SpecieKrabby.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Krabby() : base(
			98,
			SpecieKrabby.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}