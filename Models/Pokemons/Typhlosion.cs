using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Typhlosion Specie to store common natural stats of every {'abilities': ['blaze', 'flash-fire'], 'base_experience': 240, 'height': 17, 'id': 157, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'cut', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'leer', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'fire-blast', 'swift', 'rest', 'rock-slide', 'substitute', 'flame-wheel', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'eruption', 'secret-power', 'blast-burn', 'overheat', 'rock-tomb', 'aerial-ace', 'covet', 'gyro-ball', 'natural-gift', 'fling', 'focus-blast', 'giga-impact', 'shadow-claw', 'rock-climb', 'lava-plume', 'captivate', 'flame-charge', 'round', 'incinerate', 'inferno', 'fire-pledge', 'bulldoze', 'work-up', 'wild-charge', 'confide', 'power-up-punch', 'burn-up'], 'name': 'typhlosion', 'stats': {'hp': 78, 'attack': 84, 'defense': 78, 'special-attack': 109, 'special-defense': 85, 'speed': 100}, 'types': ['fire'], 'weight': 795, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バクフーン', 'roomaji': 'Bakphoon', 'ko': '블레이범', 'zh-Hant': '火爆獸', 'fr': 'Typhlosion', 'de': 'Tornupto', 'es': 'Typhlosion', 'it': 'Typhlosion', 'en': 'Typhlosion', 'ja': 'バクフーン', 'zh-Hans': '火暴兽'}, 'genera': {'ja-Hrkt': 'かざんポケモン', 'ko': '화산포켓몬', 'zh-Hant': '火山寶可夢', 'fr': 'Pokémon Volcan', 'de': 'Vulkan', 'es': 'Pokémon Volcán', 'it': 'Pokémon Vulcano', 'en': 'Volcano Pokémon', 'ja': 'かざんポケモン', 'zh-Hans': '火山宝可梦'}}
	public class SpecieTyphlosion : PokemonSpecie
	{
#nullable enable
		private static SpecieTyphlosion? _instance = null;
#nullable restore
        public static SpecieTyphlosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyphlosion();
                }
                return _instance;
            }
        }

		public SpecieTyphlosion() : base(
			"Typhlosion",
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100			
		) {}
	}


	//Typhlosion Pokemon Class
	public class Typhlosion : Pokemon
	{

		public Typhlosion(string nickname, int level)
		: base(
				157,
				SpecieTyphlosion.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Typhlosion(int level)
		: base(
				157,
				SpecieTyphlosion.Instance, // Pokemon Specie
				"Typhlosion", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Typhlosion() : base(
			157,
			SpecieTyphlosion.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}