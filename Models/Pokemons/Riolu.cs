using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Riolu Specie to store common natural stats of every {'abilities': ['steadfast', 'inner-focus', 'prankster'], 'base_experience': 57, 'height': 7, 'id': 447, 'moves': ['ice-punch', 'thunder-punch', 'swords-dance', 'headbutt', 'bite', 'roar', 'low-kick', 'counter', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'screech', 'double-team', 'swift', 'high-jump-kick', 'rest', 'rock-slide', 'substitute', 'mind-reader', 'snore', 'reversal', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'facade', 'focus-punch', 'follow-me', 'helping-hand', 'role-play', 'brick-break', 'secret-power', 'blaze-kick', 'meteor-mash', 'rock-tomb', 'sky-uppercut', 'iron-defense', 'bulk-up', 'natural-gift', 'feint', 'payback', 'fling', 'copycat', 'magnet-rise', 'force-palm', 'poison-jab', 'drain-punch', 'vacuum-wave', 'focus-blast', 'nasty-plot', 'bullet-punch', 'shadow-claw', 'zen-headbutt', 'captivate', 'low-sweep', 'round', 'circle-throw', 'retaliate', 'final-gambit', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'riolu', 'stats': {'hp': 40, 'attack': 70, 'defense': 40, 'special-attack': 35, 'special-defense': 40, 'speed': 60}, 'types': ['fighting'], 'weight': 202, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 1, 'capture_rate': 75, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'リオル', 'roomaji': 'Riolu', 'ko': '리오르', 'zh-Hant': '利歐路', 'fr': 'Riolu', 'de': 'Riolu', 'es': 'Riolu', 'it': 'Riolu', 'en': 'Riolu', 'ja': 'リオル', 'zh-Hans': '利欧路'}, 'genera': {'ja-Hrkt': 'はもんポケモン', 'ko': '파문포켓몬', 'zh-Hant': '波紋寶可夢', 'fr': 'Pokémon Émanation', 'de': 'Wellenspiel', 'es': 'Pokémon Emanación', 'it': 'Pokémon Emanazione', 'en': 'Emanation Pokémon', 'ja': 'はもんポケモン', 'zh-Hans': '波纹宝可梦'}}
	public class SpecieRiolu : PokemonSpecie
	{
#nullable enable
		private static SpecieRiolu? _instance = null;
#nullable restore
        public static SpecieRiolu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRiolu();
                }
                return _instance;
            }
        }

		public SpecieRiolu() : base(
			"Riolu",
			40, // HPs
			70, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Riolu Pokemon Class
	public class Riolu : Pokemon
	{

		public Riolu(string nickname, int level) : base(
			447,
			SpecieRiolu.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Riolu() : base(
			447,
			SpecieRiolu.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}