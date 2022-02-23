using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoqueen Specie to store common natural stats of every {'abilities': ['poison-point', 'rivalry', 'sheer-force'], 'base_experience': 227, 'height': 13, 'id': 31, 'moves': ['mega-punch', 'pay-day', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'double-kick', 'mega-kick', 'headbutt', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'poison-sting', 'roar', 'flamethrower', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'defense-curl', 'reflect', 'bide', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'detect', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'secret-power', 'rock-tomb', 'aerial-ace', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'poison-jab', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'shadow-claw', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'hone-claws', 'venoshock', 'smack-down', 'sludge-wave', 'round', 'echoed-voice', 'chip-away', 'incinerate', 'quash', 'bulldoze', 'dragon-tail', 'drill-run', 'confide', 'power-up-punch'], 'name': 'nidoqueen', 'stats': {'hp': 90, 'attack': 92, 'defense': 87, 'special-attack': 75, 'special-defense': 85, 'speed': 76}, 'types': ['poison', 'ground'], 'weight': 600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ニドクイン', 'roomaji': 'Nidoqueen', 'ko': '니드퀸', 'zh-Hant': '尼多后', 'fr': 'Nidoqueen', 'de': 'Nidoqueen', 'es': 'Nidoqueen', 'it': 'Nidoqueen', 'en': 'Nidoqueen', 'ja': 'ニドクイン', 'zh-Hans': '尼多后'}, 'genera': {'ja-Hrkt': 'ドリルポケモン', 'ko': '드릴포켓몬', 'zh-Hant': '鑽錐寶可夢', 'fr': 'Pokémon Perceur', 'de': 'Bohrer', 'es': 'Pokémon Taladro', 'it': 'Pokémon Trapano', 'en': 'Drill Pokémon', 'ja': 'ドリルポケモン', 'zh-Hans': '钻锥宝可梦'}}
	public class SpecieNidoqueen : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoqueen? _instance = null;
#nullable restore
        public static SpecieNidoqueen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoqueen();
                }
                return _instance;
            }
        }

		public SpecieNidoqueen() : base(
			"Nidoqueen",
			90, // HPs
			92, 87, // Attack & Defense
			75, 85, // Special Attack & Defense
			76			
		) {}
	}


	//Nidoqueen Pokemon Class
	public class Nidoqueen : Pokemon
	{

		public Nidoqueen(string nickname, int level) : base(
			31,
			SpecieNidoqueen.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Ground.Instance			
		) {}

		public Nidoqueen() : base(
			31,
			SpecieNidoqueen.Instance, // Pokemon Specie
			Poison.Instance, Ground.Instance			
		) {}
	}
}