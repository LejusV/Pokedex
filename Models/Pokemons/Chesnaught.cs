using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chesnaught Specie to store common natural stats of every {'abilities': ['overgrow', 'bulletproof'], 'base_experience': 239, 'height': 16, 'id': 652, 'moves': ['thunder-punch', 'swords-dance', 'cut', 'vine-whip', 'tackle', 'body-slam', 'take-down', 'pin-missile', 'bite', 'growl', 'roar', 'hyper-beam', 'low-kick', 'strength', 'leech-seed', 'solar-beam', 'earthquake', 'dig', 'toxic', 'double-team', 'reflect', 'flash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'protect', 'belly-drum', 'sludge-bomb', 'giga-drain', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'needle-arm', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'dragon-claw', 'frenzy-plant', 'bulk-up', 'mud-shot', 'hammer-arm', 'gyro-ball', 'feint', 'payback', 'fling', 'worry-seed', 'poison-jab', 'seed-bomb', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'iron-head', 'stone-edge', 'grass-knot', 'wood-hammer', 'hone-claws', 'smack-down', 'low-sweep', 'round', 'retaliate', 'grass-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'spiky-shield', 'power-up-punch'], 'name': 'chesnaught', 'stats': {'hp': 88, 'attack': 107, 'defense': 122, 'special-attack': 74, 'special-defense': 75, 'speed': 64}, 'types': ['grass', 'fighting'], 'weight': 900, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ブリガロン', 'ko': '브리가론', 'zh-Hant': '布里卡隆', 'fr': 'Blindépique', 'de': 'Brigaron', 'es': 'Chesnaught', 'it': 'Chesnaught', 'en': 'Chesnaught', 'ja': 'ブリガロン', 'zh-Hans': '布里卡隆'}, 'genera': {'ja-Hrkt': 'とげよろいポケモン', 'ko': '가시갑옷포켓몬', 'zh-Hant': '刺鎧寶可夢', 'fr': 'Pokémon Épinarmure', 'de': 'Spitzpanzer', 'es': 'Pokémon Corazaespín', 'it': 'Pokémon Spincorazza', 'en': 'Spiny Armor Pokémon', 'ja': 'とげよろいポケモン', 'zh-Hans': '刺铠宝可梦'}}
	public class SpecieChesnaught : PokemonSpecie
	{
#nullable enable
		private static SpecieChesnaught? _instance = null;
#nullable restore
        public static SpecieChesnaught Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChesnaught();
                }
                return _instance;
            }
        }

		public SpecieChesnaught() : base(
			"Chesnaught",
			88, // HPs
			107, 122, // Attack & Defense
			74, 75, // Special Attack & Defense
			64			
		) {}
	}


	//Chesnaught Pokemon Class
	public class Chesnaught : Pokemon
	{

		public Chesnaught(string nickname, int level) : base(
			652,
			SpecieChesnaught.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Fighting.Instance			
		) {}

		public Chesnaught() : base(
			652,
			SpecieChesnaught.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
	}
}