using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Quilladin Specie to store common natural stats of every {'abilities': ['overgrow', 'bulletproof'], 'base_experience': 142, 'height': 7, 'id': 651, 'moves': ['thunder-punch', 'swords-dance', 'cut', 'vine-whip', 'tackle', 'body-slam', 'take-down', 'pin-missile', 'bite', 'growl', 'roar', 'low-kick', 'strength', 'leech-seed', 'solar-beam', 'dig', 'toxic', 'double-team', 'reflect', 'flash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'protect', 'sludge-bomb', 'giga-drain', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'needle-arm', 'rock-tomb', 'aerial-ace', 'iron-defense', 'bulk-up', 'mud-shot', 'gyro-ball', 'payback', 'fling', 'worry-seed', 'poison-jab', 'seed-bomb', 'drain-punch', 'energy-ball', 'shadow-claw', 'zen-headbutt', 'iron-head', 'stone-edge', 'grass-knot', 'wood-hammer', 'hone-claws', 'smack-down', 'low-sweep', 'round', 'retaliate', 'grass-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'quilladin', 'stats': {'hp': 61, 'attack': 78, 'defense': 95, 'special-attack': 56, 'special-defense': 58, 'speed': 57}, 'types': ['grass'], 'weight': 290, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ハリボーグ', 'ko': '도치보구', 'zh-Hant': '胖胖哈力', 'fr': 'Boguérisse', 'de': 'Igastarnish', 'es': 'Quilladin', 'it': 'Quilladin', 'en': 'Quilladin', 'ja': 'ハリボーグ', 'zh-Hans': '胖胖哈力'}, 'genera': {'ja-Hrkt': 'とげよろいポケモン', 'ko': '가시갑옷포켓몬', 'zh-Hant': '刺鎧寶可夢', 'fr': 'Pokémon Épinarmure', 'de': 'Spitzpanzer', 'es': 'Pokémon Corazaespín', 'it': 'Pokémon Spincorazza', 'en': 'Spiny Armor Pokémon', 'ja': 'とげよろいポケモン', 'zh-Hans': '刺铠宝可梦'}}
	public class SpecieQuilladin : PokemonSpecie
	{
#nullable enable
		private static SpecieQuilladin? _instance = null;
#nullable restore
        public static SpecieQuilladin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuilladin();
                }
                return _instance;
            }
        }

		public SpecieQuilladin() : base(
			"Quilladin",
			61, // HPs
			78, 95, // Attack & Defense
			56, 58, // Special Attack & Defense
			57			
		) {}
	}


	//Quilladin Pokemon Class
	public class Quilladin : Pokemon
	{

		public Quilladin(string nickname, int level) : base(
			651,
			SpecieQuilladin.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Quilladin() : base(
			651,
			SpecieQuilladin.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}