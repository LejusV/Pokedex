using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Krokorok Specie to store common natural stats of every {'abilities': ['intimidate', 'moxie', 'anger-point'], 'base_experience': 123, 'height': 10, 'id': 552, 'moves': ['cut', 'sand-attack', 'thrash', 'leer', 'bite', 'roar', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'rage', 'double-team', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'sand-tomb', 'payback', 'assurance', 'embargo', 'fling', 'dark-pulse', 'aqua-tail', 'earth-power', 'shadow-claw', 'stone-edge', 'stealth-rock', 'grass-knot', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'incinerate', 'retaliate', 'bulldoze', 'snarl', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'krokorok', 'stats': {'hp': 60, 'attack': 82, 'defense': 45, 'special-attack': 45, 'special-defense': 45, 'speed': 74}, 'types': ['ground', 'dark'], 'weight': 334, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ワルビル', 'ko': '악비르', 'zh-Hant': '混混鱷', 'fr': 'Escroco', 'de': 'Rokkaiman', 'es': 'Krokorok', 'it': 'Krokorok', 'en': 'Krokorok', 'ja': 'ワルビル', 'zh-Hans': '混混鳄'}, 'genera': {'ja-Hrkt': 'さばくワニポケモン', 'ko': '사막악어포켓몬', 'zh-Hant': '沙漠鱷魚寶可夢', 'fr': 'Pokémon Croco Sable', 'de': 'Wüstenkroko', 'es': 'Pokémon Desierdrilo', 'it': 'Pokémon Sabbiadrillo', 'en': 'Desert Croc Pokémon', 'ja': 'さばくワニポケモン', 'zh-Hans': '沙漠鳄鱼宝可梦'}}
	public class SpecieKrokorok : PokemonSpecie
	{
#nullable enable
		private static SpecieKrokorok? _instance = null;
#nullable restore
        public static SpecieKrokorok Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrokorok();
                }
                return _instance;
            }
        }

		public SpecieKrokorok() : base(
			"Krokorok",
			60, // HPs
			82, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			74			
		) {}
	}


	//Krokorok Pokemon Class
	public class Krokorok : Pokemon
	{

		public Krokorok(string nickname, int level) : base(
			552,
			SpecieKrokorok.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Dark.Instance			
		) {}

		public Krokorok() : base(
			552,
			SpecieKrokorok.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
	}
}